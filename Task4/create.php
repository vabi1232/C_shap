<?php
require_once 'config.php';
$name=$address=$tel=$F=$location=$start_date=$end_date="";
$name_err=$address_err=$tel_err=$F_err=$location_err=$start_date_err=$end_date_err="";
if ($_SERVER["REQUEST_METHOD"]=="POST"){
    $input_name = trim($_POST["name"]);
    if (empty($input_name)){
        $name_err="Please enter a name.";
    }elseif (!filter_var(trim($_POST["name"]),FILTER_VALIDATE_REGEXP,
        array("options"=>array("regexp"=>"/^[a-zA-Z'-.\s ]+$/")))){
        $name_err ="Please enter a valid name.";
    }else{
        $name = $input_name;
    }
    //Address
    $input_address =trim($_POST["address"]);
    if (empty($input_address)){
        $address_err="Please enter an address";
    }else{
        $address=  $input_address;
    }
    //Telephone
    $input_tel = trim($_POST["tel"]);
    if (empty($input_tel)){
        $tel_err="Please enter the telephone.";
    }
    else{
        $tel=  $input_tel;
    }
    //F
    $input_F= trim($_POST["F"]);
    if (empty($input_F)){
        $F_err="Please enter F.";
    }
    else{
        $F=  $input_F;
    }
    //Location
    $input_location = trim($_POST["location"]);
    if (empty($input_location)){
        $location_err="Please enter the location";
    }else{
        $location=  $input_location;
    }
    //Start date
    $input_start_date = trim($_POST["start_date"]);
    if (empty($input_start_date)){
        $start_date_err="Please enter start date";
    }else{
        $start_date=  $input_start_date;
    }
    $input_end_date = trim($_POST["end_date"]);
    if (empty($input_end_date)){
        $end_date_err="Please enter end date";
    }else{
        $end_date=  $input_end_date;
    }
    if (empty($name_err)&&empty($address_err)&&empty($tel_err)&&empty($F_err)&&empty($location_err)&&empty($start_date_err)&&empty($end_date_err)){
        $sql="INSERT INTO Task4 (name,address,tel,F,location,start_date,end_date) VALUES (?,?,?,?,?,?,?)";
        echo $sql;
        if ($stmt =mysqli_prepare($link, $sql)){
            mysqli_stmt_bind_param($stmt,"ssiisss",$param_name,$param_address,$param_tel,$param_F,$param_location,$param_start_date,$param_end_date);
            $param_name=$name;
            $param_address=$address;
            $param_tel=$tel;
            $param_F=$F;
            $param_location=$location;
            $param_start_date=$start_date;
            $param_end_date=$end_date;
            if (mysqli_stmt_execute($stmt)){
                header("location: index.php");
                exit();
            }else{
                echo "Something went wrong. Please try again later";
            }
        }
        mysqli_stmt_close($stmt);

    }
    mysqli_close($link);
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Dashboard</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.css">
    <style type="text/css">
        .wrapper{
            width: 900px;
            margin: 0 auto;
        }
    </style>
</head>
<body>
<div class="wrapper">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="page-header">
                    <h1>View Record Covid-19</h1>
                </div>
                <p>Please fill this form and submit to add employee record to the database.</p>
                <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                    <div class="form-group <?php echo (!empty($name_err)) ? 'has--error' :'';?>">
                        <label>Name</label>
                        <input type="text" name="name" class="form-control" value="">
                        <span class="help-block"><?php echo $name_err; ?></span>
                    </div>

                    <div class="form-group <?php echo (!empty($address_err)) ? 'has--error' :'';?>">
                        <label>Address</label>
                        <input type="text" name="address" class="form-control" value="">
                        <span class="help-block"><?php echo $address_err; ?></span>
                    </div>

                    <div class="form-group <?php echo (!empty($tel_err)) ? 'has--error' :'';?>">
                        <label>Phone</label>
                        <input type="tel" name="tel" class="form-control" value="">
                        <span class="help-block"><?php echo $tel_err; ?></span>
                    </div>

                    <div class="form-group <?php echo (!empty($F_err)) ? 'has--error' :'';?>">
                        <label>F</label>
                        <input type="text" name="F" class="form-control" value="">
                        <span class="help-block"><?php echo $F_err; ?></span>
                    </div>

                    <div class="form-group <?php echo (!empty($location_err)) ? 'has--error' :'';?>">
                        <label>Location</label>
                        <input type="text" name="location" class="form-control" value="">
                        <span class="help-block"><?php echo $location_err; ?></span>
                    </div>

                    <div class="form-group <?php echo (!empty($start_date_err)) ? 'has--error' :'';?>">
                        <label>Start Date</label>
                        <input type="text" name="start_date" class="form-control" value="">
                        <span class="help-block"><?php echo $start_date_err; ?></span>
                    </div>
                    <div class="form-group <?php echo (!empty($end_date_err)) ? 'has--error' :'';?>">
                        <label>End Date</label>
                        <input type="text" name="end_date" class="form-control" value="">
                        <span class="help-block"><?php echo $start_date_err; ?></span>
                    </div>
                    <input type="submit" class="btn btn-primary" value="Submit">
                    <a href="index.php" class="btn btn-default">Cancel</a>
                </form>
            </div>
        </div>
    </div>
</div>
</body>
</html>

