<?php
declare(strict_types=1);

namespace robertontl\mylittlepony;

require 'Classes/Controller/GameController.php';
session_start();

use robertontl\mylittlepony\Classes\Controller\GameController;

$playerOne = $_POST['player'];
$playerOne = trim($playerOne);
$playerOne = stripslashes($playerOne);
$playerOne = htmlspecialchars($playerOne);

$game = new GameController;

if ($_POST['modus'] == 'start') {
    $game->createPlayers($playerOne);
    $game->createCards();
    $players = $game->getPlayers();
    $_SESSION['players'] = $players;

    $cards = $game->getCards();

    $game->shuffleCards($cards);
    $shuffledCards = $game->getCards();
    $_SESSION['shuffledCards'] = $shuffledCards;

    $game->distributeCards($players, $shuffledCards);
}

$players = $_SESSION['players'];
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
                <?php
                    if ($game->hasEveryPlayerEnoughCards($players) == false) {
                        if ($game->countTrumpedCards($players, 0) > $game->countTrumpedCards($players, 1)) {
                ?>
                            <h4>Herzlichen Glückwunsch <?=$players[0]->getName();?> - du hast gewonnen! ;-)</h4>
                <?php
                        } else {
                ?>
                            <h4><?=$players[0]->getName();?> - du hast leider verloren! :-(</h4>
                <?php
                        }
                ?>
                            <p>Anzahl der Runden, die du gewonnen hast: <strong><?=$game->countTrumpedCards($players, 0);?></strong></p>
                            <p>
                <?php
                                for ($i = 0; $i < $game->countTrumpedCards($players, 0); $i++) {
                ?>
                                    <img src="<?=$players[0]->getTrumpedCards()[$i]->getImage();?>" style="width: 262px; height: 415px;" />
                <?php
                                }
                ?>
                            </p>
                            <p>Anzahl der Runden, die dein Gegner gewonnen hat: <strong><?=$game->countTrumpedCards($players, 1);?></strong></p>
                            <p>
                <?php
                                for ($i = 0; $i < $game->countTrumpedCards($players, 1); $i++) {
                ?>
                                    <img src="<?=$players[1]->getTrumpedCards()[$i]->getImage();?>" style="width: 262px; height: 415px;" />
                <?php
                                }
                ?>
                            </p>
                        <form action="index.php" method="post">
                            <button type="submit" class="btn btn-primary">Neustart</button>
                        </form>
                <?php
                    } else {
                ?>
                        <h4>Hallo <?=$players[0]->getName();?>.</h4>
                        <small class="text-body-secondary">Folgende Karte liegt spielbereit:</small>
                <?php
                    }
                ?>
            </div>
            <div class="row justify-content-center" style="margin-top: 10px;">
                <div class="card" style="width: 18rem;">
                    <img src="<?=$players[0]->getCards()[0]->getImage();?>" class="card-img-top" alt="..." style="width: 262px; height: 415px;">
                    <div class="card-body text-start">
                        <h5 class="card-title">1. <?=$players[0]->getCards()[0]->getName();?></h5>
                        <small class="text-body-secondary">Wähle deine Eigenschaft.</small>
                        <form method="post" action="play.php">
                            <div class="form-check">
                                <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault1" checked
                                       value="<?=$players[0]->getCards()[0]->getProperties()['size'];?> size" />
                                <label class="form-check-label" for="flexRadioDefault1">
                                    Stockmaß: <?=$players[0]->getCards()[0]->getProperties()['size'];?> cm
                                </label>
                            </div>
                            <div class="form-check">
                                <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault2"
                                       value="<?=$players[0]->getCards()[0]->getProperties()['intelligence'];?> intelligence" />
                                <label class="form-check-label" for="flexRadioDefault2">
                                    Intelligenz: <?=$players[0]->getCards()[0]->getProperties()['intelligence'];?> Pkt.
                                </label>
                            </div>
                            <div class="form-check">
                                <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault3"
                                       value="<?=$players[0]->getCards()[0]->getProperties()['speed'];?> speed" />
                                <label class="form-check-label" for="flexRadioDefault3">
                                    Geschwindigkeit: <?=$players[0]->getCards()[0]->getProperties()['speed'];?> km/h
                                </label>
                            </div>
                            <div class="form-check">
                                <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault4"
                                       value="<?=$players[0]->getCards()[0]->getProperties()['price'];?> price" />
                                <label class="form-check-label" for="flexRadioDefault4">
                                    Preis: <?=$players[0]->getCards()[0]->getProperties()['price'];?> €
                                </label>
                            </div>
                            <button type="submit" class="btn btn-primary">Auswählen</button>
                        </form>
                    </div>
                </div>
                <?php
                    if ($game->countCards($players, 0) > 1) {
                ?>
                <small class="text-body-secondary" style="margin-top: 10px;">Weitere folgende Karten wurden dir zugelost:</small>
                <?php
                    
                        for ($i = 1; $i <= $game->countCards($players, 0)-1; $i++) {
                ?>
                            <div class="card" style="width: 18rem; margin-top: 10px; margin-right: 10px;">
                                <img src="<?=$players[0]->getCards()[$i]->getImage();?>" class="card-img-top" alt="..." style="width: 262px; height: 415px;">
                                <div class="card-body text-start">
                                    <h5 class="card-title"><?=$i+1;?>. <?=$players[0]->getCards()[$i]->getName();?></h5>
                                </div>
                            </div>
                <?php
                        }
                    }
                ?>
                <p>&nbsp;</p>
            </div>
        </div>
    </body>
</html>
