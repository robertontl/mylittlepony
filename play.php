<?php
declare(strict_types=1);

namespace robertontl\mylittlepony;

require 'Classes/Controller/GameController.php';
session_start();

use robertontl\mylittlepony\Classes\Controller\GameController;

$game = new GameController;

$players = $_SESSION['players'];
$property = $_POST['flexRadioDefault'];
?>
<!DOCTYPE html>
<html lang="de">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>MyLittlePony</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" 
              integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" 
                integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
    </head>
    <body style="background-color: #a1b7c5;">
        <div class="text-bg-dark p-3 text-center" style="width: 100%; height: 4.5rem;">
            <h3><a href="index.php" style="text-decoration: none; color: #FFFFFF;">MyLittlePony</a></h3>
        </div>
        <div class="container text-center" style="margin-top: 25px;">
            <div class="row justify-content-center">
                <h4>Hallo <?=$players[0]->getName();?>.</h4>
                <small class="text-body-secondary">Mit der Eigenschaft der folgenden Karte hast du gespielt:</small>
            </div>
            <div class="row justify-content-center" style="margin-top: 10px;">
                <div class="col-4 text-center">
                    <h4><?=$players[0]->getName();?></h4>
                    <div class="card text-center" style="width: 18rem; margin: auto;">
                        <img src="<?=$players[0]->getCards()[0]->getImage();?>" class="card-img-top" alt="...">
                        <div class="card-body text-start">
                            <h5 class="card-title"><?=$players[0]->getCards()[0]->getName();?></h5>
                            <small class="text-body-secondary">Wähle deine Eigenschaft.</small>
                            <form method="post" action="start.php">
                                <div class="form-check">
                                    <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault1"
                                        <?php echo (str_contains($property, 'size')) ? 'checked' : 'disabled';?> />
                                    <label class="form-check-label" for="flexRadioDefault1">
                                        Stockmaß: <?=$players[0]->getCards()[0]->getProperties()['size'];?> cm
                                    </label>
                                </div>
                                <div class="form-check">
                                    <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault2"
                                        <?php echo (str_contains($property, 'intelligence')) ? 'checked' : 'disabled';?> />
                                    <label class="form-check-label" for="flexRadioDefault2">
                                        Intelligenz: <?=$players[0]->getCards()[0]->getProperties()['intelligence'];?> Pkt.
                                    </label>
                                </div>
                                <div class="form-check">
                                    <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault3"
                                        <?php echo (str_contains($property, 'speed')) ? 'checked' : 'disabled';?> />
                                    <label class="form-check-label" for="flexRadioDefault3">
                                        Geschwindigkeit: <?=$players[0]->getCards()[0]->getProperties()['speed'];?> km/h
                                    </label>
                                </div>
                                <div class="form-check">
                                    <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault4"
                                        <?php echo (str_contains($property, 'price')) ? 'checked' : 'disabled';?> />
                                    <label class="form-check-label" for="flexRadioDefault4">
                                        Preis: <?=$players[0]->getCards()[0]->getProperties()['price'];?> €
                                    </label>
                                    <input type="hidden" name="player" value="<?=$_SESSION['players'][0]->getName();?>" />
                                    <input type="hidden" name="modus" value="continue" />
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
                <div class="col-4 text-center">
                    <h4><?=$players[1]->getName();?></h4>
                    <div class="card text-start" style="width: 18rem; margin: auto;">
                        <img src="<?=$players[1]->getCards()[0]->getImage();?>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><?=$players[1]->getCards()[0]->getName();?></h5>
                            <small class="text-body-secondary">Wähle deine Eigenschaft.</small>
                            <form method="post" action="start.php">
                                <div class="form-check">
                                    <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault1"
                                        <?php echo (str_contains($property, 'size')) ? 'checked' : 'disabled';?> />
                                    <label class="form-check-label" for="flexRadioDefault1">
                                        Stockmaß: <?=$players[1]->getCards()[0]->getProperties()['size'];?> cm
                                    </label>
                                </div>
                                <div class="form-check">
                                    <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault2"
                                        <?php echo (str_contains($property, 'intelligence')) ? 'checked' : 'disabled';?> />
                                    <label class="form-check-label" for="flexRadioDefault2">
                                        Intelligenz: <?=$players[1]->getCards()[0]->getProperties()['intelligence'];?> Pkt.
                                    </label>
                                </div>
                                <div class="form-check">
                                    <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault3"
                                        <?php echo (str_contains($property, 'speed')) ? 'checked' : 'disabled';?> />
                                    <label class="form-check-label" for="flexRadioDefault3">
                                        Geschwindigkeit: <?=$players[1]->getCards()[0]->getProperties()['speed'];?> km/h
                                    </label>
                                </div>
                                <div class="form-check">
                                    <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault4"
                                        <?php echo (str_contains($property, 'price')) ? 'checked' : 'disabled';?> />
                                    <label class="form-check-label" for="flexRadioDefault4">
                                        Preis: <?=$players[1]->getCards()[0]->getProperties()['price'];?> €
                                    </label>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row justify-content-center" style="margin-top: 10px;">
                <?php
                    if ($game->playRound($players, $property) == true) {
                ?>
                    <button type="button" class="btn btn-success">GEWONNEN :-)</button>
                <?php
                    } else {
                ?>
                <p class="btn btn-danger">VERLOREN :-(</p>
                <?php
                    }
                ?>
            </div>
            <div class="row justify-content-center" style="margin-top: 10px;">
                <form method="post" action="start.php">
                    <input type="hidden" name="player" value="<?=$_SESSION['players'][0]->getName();?>" />
                    <input type="hidden" name="modus" value="continue" />
                    <button type="submit" class="btn btn-primary">Weiter</button>
                </form>
            </div>
            <p>&nbsp;</p>
        </div>
    </body>
</html>
