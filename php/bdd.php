<?php 

function connectBDD() {
    $user = "root";
    $pass = "";
    $base = "lab2";
    $serv = "localhost";
    $cnx = new mysqli($serv, $user, $pass, $base);
    return $cnx;
}
function disconnectBDD($cnx) {
    $cnx->close();
}
function requete($cnx, $req) {
    if ($res = mysqli_query($cnx, $req)) {
    } else {
        echo "Error: " . $req ;
    }
    return $res;
}

?>