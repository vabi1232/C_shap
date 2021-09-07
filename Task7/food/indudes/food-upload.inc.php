<?php
if (isset($_POST['submit'])){
    $newFileName= $_POST['filename'];
    if (empty($newFileName)){
        $newFileName="gallery";
    }else{
        $newFileName =strtolower(str_replace(" ","-",$newFileName));
    }
    $imgTitle =$_POST['filetitle'];
    $imgDesc= $_POST['filedesc'];

    $file=$_FILES['file'];

    $fileName=$file["name"];
    $fileType=$file["type"];
    $fileTempName=$file["tmp_name"];
    $fileError=$file["error"];
    $fileSize=$file["size"];

    $fileExt = explode(".",$fileName);
    $fileActuaExt=strtolower(end($fileExt));
    $allowed = array("jpg","jpeg","png");

    if (in_array($fileActuaExt,$allowed)){
        if ($fileError===0){
            if ($fileSize<7000000){
                $imageFullName= $newFileName ."." . uniqid("",true) . "." .$fileActuaExt;
                $fileDestination ="../image/gallery/".$imageFullName;
//                echo  $fileDestination;
                include_once 'dhn.inc.php';

                if (empty($imgTitle)||empty($imgDesc)){
                    header("Location: ../food.php?upload=empty");
                    exit();
                }else{
                    $sql = "SELECT * FROM food";
                    $stmt = mysqli_stmt_init($conn);
                    if (!mysqli_stmt_prepare($stmt,$sql)){
                        echo "SQL statement failed";
                    }else{
                        mysqli_stmt_execute($stmt);
                        $result=mysqli_stmt_get_result($stmt);
                        $rowCount= mysqli_num_rows($result);
                        $setImageOrder = $rowCount +1;
                        $sql ="INSERT INTO food (titleFood,descFood,imgFullNameFood,orderFood) VALUES (?,?,?,?)";
                        if (!mysqli_stmt_prepare($stmt,$sql)){
                            echo "MY SQL statement failed";
                        }else{
                            mysqli_stmt_bind_param($stmt,"ssss",$imgTitle,$imgDesc,$imageFullName,$setImageOrder);
                            mysqli_stmt_execute($stmt);
                            move_uploaded_file($fileTempName,$fileDestination);
//                            echo  $sql;
                            header("Location: ../food.php?upload=success");
                        }
                    }
                }
            }else{
                echo "File size is too big";
                exit();
            }
        }else{
            echo "You had an error!";
            exit();
        }
    }
    else{
        echo "You need to upload a proper file type!";
        exit();
    }
}

?>