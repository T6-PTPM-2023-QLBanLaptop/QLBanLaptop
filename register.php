<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<!-- https://bootsnipp.com/tags/login -->
<!DOCTYPE html>
<html>

<head>
    <title>Register</title>
    <!--Bootsrap 4 CDN-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <!--Fontawesome CDN-->
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">
    <!--Custom styles-->
    <link rel="stylesheet" type="text/css" href="css/login.css">
</head>
<?php
if (isset($_SESSION['success'])) {
    unset($_SESSION['success']);
}

require_once('./models/users.php');
$result_check = '';

if (isset($_POST['checkUser']) || isset($_POST['checkEmail'])) {
    $users = new Users();
    $username = $_POST['username'];
    $email = $_POST['email'];
    $result_check =  $users->checkUser_Enail($username, $email);
}

if (isset($_POST['register'])) {

    $users = new Users();
    $result = $users->insert($_POST);
    if ($result == 1) {
        $_SESSION['success'] = 'Đăng ký thành công';
    } else $alert = $result;
}

?>

<body>
    <div class="container">
        <?php
        if (isset($_SESSION['success'])) {
        ?>
            <div class="alert alert-primary" role="alert">
                <?php echo $_SESSION['success'] ?>
            </div>
        <?php
        }
        ?>
        <?php
        if (isset($result_check) && $result_check != '') {
            echo '<div class="alert alert-primary" role="alert">' . " $result_check " . "</div>";
        }
        if (isset($alert)) echo '<div class="alert alert-primary" role="alert">' . " $result " . "</div>";
        ?>
        <div class="d-flex justify-content-center h-100">
            <div class="card">
                <div class="card-header">
                    <h3>Đăng ký</h3>
                </div>
                <div class="card-body">
                    <form method="post" action="">
                        <div class="form-group">
                            <label for="username">Username:</label>
                            <input type="text" name="username" class="form-control" value="<?php if (isset($result_check) && $result_check == 'OK') echo $username; ?>" id="username" placeholder="Username" required>
                            <button type="submit" name="checkUser" class="btn btn-primary">Check</button>
                        </div>
                        <div class="form-group">
                            <label for="password">Password:</label>
                            <input type="password" name="password" class="form-control" id="password" placeholder="Password" required>
                        </div>
                        <div class="form-group">
                            <label for="passwordR">Re-enter Password:</label>
                            <input type="password" name="passwordR" class="form-control" id="passwordR" placeholder="Re-enter Password" required>
                        </div>
                        <div class="form-group">
                            <label for="email">Email:</label>
                            <input type="email" name="email" class="form-control" value="<?php if (isset($result_check) && $result_check == 'OK') echo $email; ?>" id="email" placeholder="Email" required>
                            <button type="submit" name="checkEmail" class="btn btn-primary">Check</button>
                        </div>

                        <div class="form-group">
                            <label for="full_name">Họ và tên:</label>
                            <input type="text" name="full_name" class="form-control" id="full_name" placeholder="Họ và tên">
                        </div>
                        <div class="form-group">
                            <label for="address">Quận huyện tên đường, số nhà:</label>
                            <input type="text" name="address" class="form-control" id="address" placeholder="Quận huyện tên đường, số nhà">
                        </div>
                        <div class="form-group">
                            <label for="dob">Ngày sinh:</label>
                            <input type="date" name="dob" class="form-control" id="dob">
                        </div>
                        <div class="form-group">
                            <label for="city">Thành phố:</label>
                            <input type="text" name="city" class="form-control" id="city" placeholder="Thành phố">
                        </div>
                        <div class="form-group">
                            <label for="phone">Số điện thoại:</label>
                            <input type="number" name="phone" class="form-control" id="phone" placeholder="Số điện thoại">
                        </div>

                        <div class="form-check">
                            <input type="checkbox" checked="checked" class="form-check-input" name="remember" id="remember">
                            <label class="form-check-label" for="remember">Nhớ tài khoản</label>
                        </div>

                        <div class="form-group">
                            <button type="submit" name="register" class="btn btn-primary float-right">Đăng ký</button>
                        </div>
                    </form>
                </div>
                <div class="card-footer">
                    <div class="d-flex justify-content-center links">
                        <a href="login.php">Đăng nhập</a>
                    </div>
                    <div class="d-flex justify-content-center">
                        <a href="#">Quên mật khẩu?</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>

</html>