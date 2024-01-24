// Bring in the express server and create application
let express = require('express');
let app = express();
let pieRepo = require('./repos/pieRepo');
let errorHelper = require('./helpers/errorHelpers');
let cors = require('cors');

// Use the express Router object
let router = express.Router();

//Configure middle ware to support JSON data parsing in request object
app.use(express.json());

// configure cors
app.use(cors());

// Create GET to return a list of all pies
router.get('/', function (req, res, next){
  pieRepo.get(function(data){
    res.status(200).json({
      "status":200,
      "statusText":"OK",
      "message":"All pies retrieved",
      "data": data
    });
  }, function(err){
    next(err);
  });
});

router.get('/search', function(req, res, next){
  let searchObject = {
    "id":req.query.id,
    "name":req.query.name
  };

  pieRepo.search(searchObject, function(data){
    res.status(200).json({
      "status":200,
      "statusText":"OK",
      "message":"All pies retrieved",
      "data":data
    });
  },
  function(err){
    next(err);
  });
});

// CREATE
router.post('/', function(req, res, next){
  pieRepo.insert(req.body, function(data){
    res.status(201).json({
      "status":201,
      "statusText":"Created",
      "message":"New pie added",
      "data":data
    });
  }, function(err){
    next(err);
  });
});

// READ BY ID
router.get('/:id', function(req, res, next){
  pieRepo.getById(req.params.id, function(data){
    if(data){
      res.status(200).json({
        "status":200,
        "statusText":"OK",
        "message":"Single pie retrieved.",
        "data":data
      });
    }else{
      res.status(404).json({
        "status":404,
        "statusText":"Not Found",
        "message":"The pie '"+req.params.id + "'could not be found.",
        "error":{
          "code":"NOT_FOUND",
          "message":"The pie '"+req.params.id + "'could not be found."
        }
      });
    }
  }, function(err){
    next(err);
  });
});

/*
The main difference between the PUT and PATCH method is that the PUT method uses 
the request URI to supply a modified version of the requested resource which 
replaces the original version of the resource, whereas the PATCH method supplies 
a set of instructions to modify the resource.
*/

// CREATE BY ID
router.put('/:id', function(req, res, next){
  pieRepo.getById(req.params.id, function(data){
    if(data){
      //Attempt to update the data
      pieRepo.update(req.body, req.params.id, function(data){
        res.status(200).json({
          "status":200,
          "statusText":"OK",
          "message":"Pie '"+req.params.id + "' updated.",
          "data":data
        });
      });
    }else{
      res.status(404).json({
        "status":404,
        "statusText":"Not Found",
        "message":"The pie '" + req.params.id+"' could not be found.",
        "error":{
          "code":"NOT_FOUND",
          "message":"The pie '"+req.params.id+"' could not be found."
        }
      });
    }
  }, function(err){
    next(err);
  });
});

// DELETE
router.delete('/:id', function(req, res, next){
  pieRepo.getById(req.params.id, function(data){
    if(data){
      pieRepo.delete(req.params.id, function(data){
        res.status(200).json({
          "status":200,
          "statusText":"OK",
          "message":"The pie '"+req.params.id+"' is deleted",
          "data":"The pie '"+req.params.id+"' is deleted"
        });
      });
    }else{
      res.status(404).json({
        "status":404,
        "statusText":"Not Found",
        "message":"The pie '" + req.params.id + "' could not find id",
        "error":{
          "code":"NOT_FOUND",
          "message":"The pie '"+req.params.id+"' could not find id"
        }
      });
    }
  }, function(err){
    next(err);
  });
});

// UPDATE
router.patch('/:id', function(req, res, next){
  pieRepo.getById(req.params.id, function(data){
    if(data){
      pieRepo.update(req.body, req.params.id, function(data){
        res.status(200).json({
          "status":200,
          "statusText":"OK",
          "message":"Pie '"+req.params.id+"' patched.",
          "data":data
        });
      });
    }else{
      res.status(404).json({
        "status":404,
        "statusText":"Not Found",
        "message":"The pie '" + req.params.id+"' could not be found.",
        "error":{
          "code":"NOT_FOUND",
          "message":"The pie '"+req.params.id+"' could not be found."
        }
      });
    }
  }, function(err){
    next(err);
  });
});
// Configure router so all routes are prefixed with /api/
app.use('/api/', router);

// configure exception logger to console
app.use(errorHelper.logErrorsToConsole);
// configure exception logger to file
app.use(errorHelper.logErrorsToFile);
// configure client error handler
app.use(errorHelper.clientErrorHandler);
// configure catch-all exception middleware last
app.use(errorHelper.errorHandler);

// Create server to listen on port 5000
var server = app.listen(5000, function(){
  console.log('Node server is running on http://localhost:5000..');
});