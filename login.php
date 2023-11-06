<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<!DOCTYPE html>
<html>

<head>
    <title>Đăng Nhập</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="css/login.css">
</head>
<?php
require_once('D:\Xampp\htdocs\shoplaptop\db.php');
require_once('./models/users.php');
session_start();
$_SESSION['user_login'] = '';
$_SESSION['user_id'] = '';
if (isset($_POST['login'])) {
    $users = new Users();
    $user = $users->checkLogin($_POST);
    if ($user != null) {
        $_SESSION['user_login'] = $user['username'];
        $_SESSION['user_id'] = $user['id'];
        header("Location:index.php");
    } else {
        $alert = 'Sai tên đăng nhập hoặc mật khẩu!';
    }
}
?>

<body>
    <div class="container">
        <?php if (isset($alert)) echo '<div class="alert alert-primary" role="alert">' . " $alert " . "</div>"; ?>
        <div class="d-flex justify-content-center h-100">
            <div class="card">
                <div class="card-header">
                    <h3>Đăng nhập<h3>
                </div>
                <div class="card-body">
                    <form method="post" action="">
                        <div class="form-group">
                            <label for="username">Tài khoản</label>
                            <input type="text" name="username" class="form-control" id="username" placeholder="Enter username" required>
                        </div>
                        <div class="form-group">
                            <label for="password">Mật khẩu</label>
                            <input type="password" name="password" class="form-control" id="password" placeholder="Password" required>
                        </div>
                        <div class="form-check">
                            <input type="checkbox" class="form-check-input" id="remember" name="remember" checked="checked">
                            <label class="form-check-label" for="remember">Nhớ tài khoản</label>
                        </div>
                        <button type="submit" name="login" class="btn btn-primary">Đăng nhập</button>
                    </form>
                </div>
                <div class="card-footer">
                    <div class="d-flex justify-content-center links">
                        Bạn chưa có tài khoản?<a href="register.php">Đăng kí</a>
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