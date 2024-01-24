<?php require_once('../../private/initialize.php'); ?>
<?php $page_title = "Staff Menu"; ?>
<?php include(SHARED_PATH . '/staff_header.php'); ?>
    <main>
        <div id="main-menu">
            <h2>Main Menu</h2>
            <ul>
                <li><a href="<?php echo url_for('/staff/subjects/index.php');
                    ?>">Subjects</a>
                </li>
            </ul>
        </div>
    </main>
<?php include(SHARED_PATH . '/staff_footer.php'); ?>