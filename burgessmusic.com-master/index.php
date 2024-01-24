<?php include("includes/home-header.php"); ?>

<main>
    <table id="home-table" align="center">
        <tr id="home-table-row-one">
            <td><img src="images/rundmc.jpg" class="homepage-image"/></td>
            <td><img src="images/aerosmith.jpg" class="homepage-image"/></td>
            <td><img src="images/animals-1977.jpg" class="homepage-image"/></td>
            <td><img src="images/bluestraveler1.jpg" class="homepage-image"/></td>
        </tr>
        <tr id="home-table-row-two">
            <td><img src="images/zacbrownband.jpg" class="homepage-image"/></td>
            <td><img src="images/publicenemy.jpg" class="homepage-image"/></td>
            <td><img src="images/jesusiskingkanyewest.jpg" class="homepage-image"/></td>
            <td><img src="images/mayer.jpg" class="homepage-image"/></td>
        </tr>
        <tr id="home-table-row-three">
            <td><img src="images/piperatthegatesofdawn.jpg" class="homepage-image"/></td>
            <td><img src="images/whocaniturnto.jpg" class="homepage-image"/></td>
            <td><img src="images/darkside.jpg" class="homepage-image"/></td>
            <td><img src="images/journey.jpg" class="homepage-image"/></td>
        </tr>
        <tr id="home-table-row-four">
            <td><img src="images/inutero-1994.jpg" class="homepage-image"/></td>
            <td><img src="images/adele25.jpg" class="homepage-image"/></td>
            <td><img src="images/graduation.jpg" class="homepage-image"/></td>
            <td><img src="images/thebeatles.jpg" class="homepage-image"/></td>
        </tr>
    </table>
    <script>
        $(document).ready(function(){
            $("#home-table-row-one").fadeIn(800);
            $("#home-table-row-two").fadeIn(1000);
            $("#home-table-row-three").fadeIn(1200);
            $("#home-table-row-four").fadeIn(1400);
        });
    </script>
</main>

<?php include("includes/home-footer.php"); ?>
