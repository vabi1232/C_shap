<?php
$_SESSION['username']="Admin";
?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>My Portfolio</title>
    <meta name="viewport" content="width=device-width,initial-scale=1.0">
    <link href="https://fonts.googleapis.com/css?family=Catamaran:100,200,300,400,500,600,700,800,900|Cormorant+Garamond:300,300i,400,400i,500,500i,600,600i,700,700i" rel="stylesheet">
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css">
    <link rel="stylesheet" href="style.css">
    <style>
        /*
html5doctor.com Reset Stylesheet
v1.6.1
Last Updated: 2010-09-17
Author: Richard Clark - http://richclarkdesign.com
Twitter: @rich_clark
*/

        html, body, div, span, object, iframe,
        h1, h2, h3, h4, h5, h6, p, blockquote, pre,
        abbr, address, cite, code,
        del, dfn, em, img, ins, kbd, q, samp,
        small, strong, sub, sup, var,
        b, i,
        dl, dt, dd, ol, ul, li,
        fieldset, form, label, legend,
        table, caption, tbody, tfoot, thead, tr, th, td,
        article, aside, canvas, details, figcaption, figure,
        footer, header, hgroup, menu, nav, section, summary,
        time, mark, audio, video {
            margin:0;
            padding:0;
            border:0;
            outline:0;
            font-size:100%;
            vertical-align:baseline;
            background:transparent;
        }

        body {
            line-height:1;
        }

        article,aside,details,figcaption,figure,
        footer,header,hgroup,menu,nav,section {
            display:block;
        }

        nav ul {
            list-style:none;
        }

        blockquote, q {
            quotes:none;
        }

        blockquote:before, blockquote:after,
        q:before, q:after {
            content:'';
            content:none;
        }

        a {
            margin:0;
            padding:0;
            font-size:100%;
            vertical-align:baseline;
            background:transparent;
        }

        /* change colours to suit your needs */
        ins {
            background-color:#ff9;
            color:#000;
            text-decoration:none;
        }

        /* change colours to suit your needs */
        mark {
            background-color:#ff9;
            color:#000;
            font-style:italic;
            font-weight:bold;
        }

        del {
            text-decoration: line-through;
        }

        abbr[title], dfn[title] {
            border-bottom:1px dotted;
            cursor:help;
        }

        table {
            border-collapse:collapse;
            border-spacing:0;
        }

        /* change border colour to suit your needs */
        hr {
            display:block;
            height:1px;
            border:0;
            border-top:1px solid #cccccc;
            margin:1em 0;
            padding:0;
        }

        input, select {
            vertical-align:middle;
        }


        /*MY CODE*/

        * {
            text-decoration: none;
        }

        main {
            padding-top: 100px;
        }

        header {
            position: fixed;
            top: 0;
            right: 0;
            left: 0;
            background-color: #fff;
            width: 100%;
            height: 100px;
            z-index: 1000;
        }

        header .header-brand {
            font-family: Catamaran;
            font-size: 24px;
            font-weight: 900;
            color: #111;
            text-transform: uppercase;
            display: block;
            margin: 0 auto;
            text-align: center;
            padding: 20px 0;
        }

        header nav ul {
            display: block;
            margin: 0 auto;
            width: fit-content;
        }

        header nav ul li {
            display: inline-block;
            float: left;
            list-style: none;
            padding: 0 16px;
        }

        header nav ul li a {
            font-family: Catamaran;
            font-size: 16px;
            color: #111;
            text-transform: uppercase;
        }

        header .header-cases {
            display: none;
        }

        @media only screen and (min-width: 1000px) {
            header .header-brand {
                margin: 31px 0;
                text-align: left;
                line-height: 38px;
                padding: 0 20px 0 40px;
                border-right: 3px solid #111;
                float: left;
            }

            header nav ul {
                margin: 20px 0px 0px 20px;
                float: left;
            }

            header nav ul li a {
                line-height: 60px;
            }

            header .header-cases {
                display: block;
                font-family: Catamaran;
                font-size: 16px;
                color: #111;
                text-transform: uppercase;
                line-height: 38px;
                border: 1px solid #111;
                float: right;
                margin-right: 40px;
                margin-top: 30px;
                padding: 0 20px;
            }
        }

        /*INDEX*/

        .index-banner {
            width: 100%;
            height: calc(100vh - 100px);
            background-image: url('img/banner.jpeg');
            background-repeat: no-repeat;
            background-position: center;
            background-size: cover;
            display: table;
        }

        .vertical-center {
            display: table-cell;
            vertical-align: middle;
        }

        .index-banner h2 {
            font-family: Catamaran;
            font-size: 60px;
            font-weight: 900;
            line-height: 70px;
            color: #fff;
            text-align: center;
            text-shadow: 2px 2px 8px #111;
        }

        .index-banner h1 {
            font-family: Cormorant Garamond;
            font-size: 28px;
            font-weight: 100;
            font-style: italic;
            line-height: 40px;
            color: #fff;
            text-align: center;
            text-shadow: 2px 2px 8px #111;
        }

        .index-links div {
            margin: 16px 16px 0;
            width: calc(100% - 32px);
            height: 100px;
            background-color: #f2f2f2;
        }

        .index-links div h3 {
            font-family: Catamaran;
            font-size: 28px;
            font-weight: 600;
            line-height: 100px;
            color: #111;
            text-align: center;
            text-transform: uppercase;
        }

        @media only screen and (min-width: 1000px) {
            .wrapper {
                width: 1000px;
                margin: 0 auto;
            }

            .index-banner {
                height: 450px;
            }

            .index-banner h1 {
                display: block;
                width: 560px;
                margin: 0 auto;
            }

            .index-links {
                overflow: hidden;
            }

            .index-links div {
                margin: 20px 10px 0;
                height: 230px;
                background-color: #f2f2f2;
                float: left;
            }

            .index-boxlink-square {
                width: calc(25% - 20px) !important;
            }

            .index-boxlink-rectangle {
                width: calc(50% - 20px) !important;
            }

            .index-links div h3 {
                line-height: 230px;
            }
        }

        /*CASES*/

        .cases-links {
            overflow: hidden;
            margin-bottom: 20px;
        }

        .cases-links h2 {
            font-family: Catamaran;
            font-size: 28px;
            font-weight: 600;
            color: #111;
            text-transform: uppercase;
        }

        .cases-links .cases-link {
            float: left;
            width: 230px;
            height: 230px;
            margin: 20px 10px 0px;
            background-color: #e3e3e3;
        }

        .cases-links .cases-link p {
            padding-top: 45%;
            font-family: Catamaran;
            font-size: 24px;
            font-weight: 600;
            color: #111;
            text-align: center;
            text-transform: uppercase;
        }

        /*CASE*/

        .case-vid h2 {
            font-family: Catamaran;
            font-size: 28px;
            font-weight: 600;
            color: #111;
            text-align: center;
            text-transform: uppercase;
        }

        .case-vid video {
            display: block;
            margin: 0 auto;
            padding: 30px 0;
        }

        .case-vid article h3 {
            font-family: Catamaran;
            font-size: 28px;
            font-weight: 600;
            color: #111;
            text-transform: uppercase;
            padding-bottom: 20px;
        }

        .case-vid article div p {
            font-family: Catamaran;
            font-size: 16px;
            font-weight: 600;
            line-height: 24px;
            color: #111;
            text-transform: uppercase;
            column-count: 3;
            column-gap: 30px;
        }

        /*GALLERY*/

        .gallery-links h2 {
            font-family: Catamaran;
            font-size: 28px;
            font-weight: 600;
            color: #111;
            text-transform: uppercase;
        }

        .gallery-container {
            display: flex;
            flex-direction: row;
            flex-wrap: wrap;
            justify-content: flex-start;
            align-content: flex-start;
        }

        .gallery-container a {
            width: 230px;
            margin: 20px 10px 0;
        }

        .gallery-container a:hover {
            opacity: 0.8;
        }

        .gallery-container a div {
            width: 100%;
            height: 235px;
            background-position: center;
            background-repeat: no-repeat;
            background-size: cover;
        }

        .gallery-container a h3 {
            font-family: Catamaran;
            font-size: 20px;
            font-weight: 700;
            color: #111;
            padding-top: 16px;
            line-height: 26px;
        }

        .gallery-container a p {
            font-family: Catamaran;
            font-size: 16px;
            font-weight: 400;
            color: #111;
            padding-top: 4px;
            line-height: 20px;
        }

        .gallery-upload {
            width: 100%;
            padding: 20px 0;
            margin-top: 20px;
            background-color: #F2F2F2;
        }

        .gallery-upload h2 {
            font-family: Catamaran;
            font-size: 28px;
            font-weight: 600;
            color: #111;
            text-transform: uppercase;
            text-align: center;
            padding-bottom: 10px;
        }

        .gallery-upload form {
            display: flex;
            flex-direction: column;
            flex-wrap: nowrap;
            align-items: center;
        }

        .gallery-upload form input {
            width: 200px;
            height: 30px;
            margin-top: 10px;
            padding: 0 15px;
            border-radius: 100px;
            box-shadow: none;
            border: 1px solid #ccc;
        }

        .gallery-upload-file-input {
            padding-top: 8px !important;
            background-color: #fefefe;
        }

        .gallery-upload form button {
            width: 120px;
            height: 30px;
            margin-top: 10px;
            border-radius: 100px;
            box-shadow: none;
            border: none;
            background-color: #4EADFF;
            color: #fff;
            font-weight: 700;
        }

        input:focus {
            outline:none !important;
        }

        /*FOOTER*/

        footer {
            width: calc(100% - 80px);
            padding: 40px 40px;
            margin-top: 20px;
            background-color: #111;
            overflow: hidden;
        }

        footer ul {
            width: fit-content;
            float: left;
            padding-left: 20px;
        }

        footer ul li {
            display: block;
            list-style: none;
        }

        footer ul li a {
            font-family: Catamaran;
            font-size: 16px;
            color: #fff;
            line-height: 40px;
        }

        .footer-links-cases {
            display: none;
        }

        .footer-sm {
            width: 50px;
            float: right;
        }

        .footer-sm img {
            width: 50px;
            height: auto;
            margin-bottom: 10px;
        }

        @media only screen and (min-width: 1000px) {
            .footer-links-cases {
                display: block;
            }

            footer ul {
                padding-right: 30px;
            }

            footer ul li p {
                font-family: Catamaran;
                font-size: 16px;
                color: #fff;
                line-height: 40px;
                text-transform: uppercase;
            }
        }

    </style>
</head>
<body>
<header>
    <a href="cases.html" class="header-brand">CODELEAN</a>
    <nav>
        <ul>
            <li><a href="#">NGO CHI THANH DAT</a></li>
            <li><a href="#">About me</a></li>
            <li><a href="#">Contact</a></li>
        </ul>
        <a href="cases.html" class="header-cases">Cases</a>
    </nav>
</header>
<main>
    <section class="gallery-links">
        <div class="wrapper">
            <h2>Gallery</h2>
            <div class="gallery-container">
                <?php
                include_once  'includes/dhn.inc.php';
                $sql = "SELECT * FROM gallery ORDER BY orderGallery DESC";
                $stmt = mysqli_stmt_init($conn);
                if (!mysqli_stmt_prepare($stmt,$sql)){
                    echo "SQL statement failed";
                }else{
                    mysqli_stmt_execute($stmt);
                    $result = mysqli_stmt_get_result($stmt);
                    while ($row = mysqli_fetch_assoc($result)){
                        echo '<a href="#">
                                    <div style="background-image: url(img/gallery/'.$row["imgFullNameGallery"].');"></div>               
                                 <h3>'.$row["titleGallery"].'</h3>
                                 <p>'.$row["descGallery"].'</p>
                                 </a>';
                    }
                }
                ?>
            </div>
            <?php
            if (isset($_SESSION['username'])){
                echo '<div class="gallery-upload">
                        <h2>Upload</h2>
                        <form action="includes/gallery-upload.inc.php" method="post" enctype="multipart/form-data">
                        <input type="text" name="filename" placeholder="File name...">
                        <input type="text" name="filetitle" placeholder="Image title...">
                        <input type="text" name="filedesc" placeholder="Image description...">
                        <input type="file" name="file">
                        <button type="submit" name="submit">UPLOAD</button>
                        </form>
                    </div>';
            }
            ?>
        </div>
    </section>
</main>


<div class="wrapper">
    <footer>
        <ul class="footer-links-main">
            <li><a href="#">Home</a></li>
            <li><a href="#">Cases</a></li>
            <li><a href="#">Portfolio</a></li>
            <li><a href="#">About me</a></li>
            <li><a href="#">Contact</a></li>
        </ul>
        <ul class="footer-links-cases">
            <li><p>Latest cases</p></li>
            <li><a href="#">MALING SHAOLIN - WEB DEVELOPMENT</a></li>
            <li><a href="#">EXCELLENTO - WEB DEVELOPMENT, SEO</a></li>
            <li><a href="#">MMTUTS - YOUTUBE CHANNEL</a></li>
            <li><a href="#">WELTEC - VIDEO PRODUCTION</a></li>
        </ul>
        <div class="footer-sm">
            <a href="#">
                <img src="img/youtube-symbol.png" alt="youtube icon" class="img_footer">
            </a>
            <a href="#">
                <img src="img/twitter-logo-button.png" alt="youtube icon" class="img_footer">
            </a>
            <a href="#">
                <img src="img/facebook-logo-button.png" alt="youtube icon" class="img_footer">
            </a>
        </div>
    </footer>
</div>
</body>
</html>