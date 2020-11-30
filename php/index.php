<?php 
$conn = connectBDD();

$filename = 'clients.txt'; 

if (file_exists($filename))
    {$open = fopen('clients.txt','r');
 

        while (!feof($open)) 
        {
            $getTextLine = fgets($open);
            $explodeLine = explode(",",$getTextLine);
            
            list($nom,$prenom,$adresse) = $explodeLine;
            
            $qry = "insert into clients (nom, prenom,adresse) values('".$nom."','".$prenom."','".$adresse."')";
            mysqli_query($conn,$qry);
            fclose($open);
        }} 

else
    {echo "Le fichier $filename n'existe pas.";}

?>