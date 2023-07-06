<?php
declare(strict_types=1);

namespace robertontl\mylittlepony\Classes\Controller;

require 'Classes/Domain/Model/Player.php';
require 'Classes/Domain/Model/Card.php';

use robertontl\mylittlepony\Classes\Domain\Model\Player;
use robertontl\mylittlepony\Classes\Domain\Model\Card;

class GameController
{
    /**
     * @var array
     */
    protected $players = array();

    /**
     * @var array
     */
    protected $cards = array();

    public function createPlayers($player): void
    {
        $playerOne = new Player;
        $playerOne->setID(1);
        $playerOne->setName($player);

        $playerTwo = new Player;
        $playerTwo->setID(2);
        $playerTwo->setName('KI');

        array_push($this->players, $playerOne);
        array_push($this->players, $playerTwo);
    }

    public function getPlayers(): array
    {
        return $this->players;
    }

    public function createCards(): void
    {
        $cardOne = new Card;
        $cardOne->setId('D3');
        $cardOne->setName('Einsiedler');
        $cardOne->setProperties(array(
            'size'  => 167,
            'intelligence' => 4,
            'speed' => 44,
            'price' => 8000
        ));
        $cardOne->setImage('img/einsiedler.jpg');
        $cardOne->setTrumped(false);

        $cardTwo = new Card;
        $cardTwo->setId('C3');
        $cardTwo->setName('Holsteiner');
        $cardTwo->setProperties(array(
            'size'  => 172,
            'intelligence' => 2,
            'speed' => 60,
            'price' => 12000
        ));
        $cardTwo->setImage('img/holsteiner.jpg');
        $cardTwo->setTrumped(false);

        $cardThree = new Card;
        $cardThree->setId('E2');
        $cardThree->setName('Andalusier');
        $cardThree->setProperties(array(
            'size'  => 158,
            'intelligence' => 4,
            'speed' => 50,
            'price' => 11000
        ));
        $cardThree->setImage('img/andalusier.jpg');
        $cardThree->setTrumped(false);

        $cardFour = new Card;
        $cardFour->setId('E3');
        $cardFour->setName('Lusitano');
        $cardFour->setProperties(array(
            'size'  => 162,
            'intelligence' => 4,
            'speed' => 52,
            'price' => 14000
        ));
        $cardFour->setImage('img/lusitano.jpg');
        $cardFour->setTrumped(false);

        $cardFive = new Card;
        $cardFive->setId('F3');
        $cardFive->setName('Budjony');
        $cardFive->setProperties(array(
            'size'  => 160,
            'intelligence' => 2,
            'speed' => 50,
            'price' => 7800
        ));
        $cardFive->setImage('img/budjony.jpg');
        $cardFive->setTrumped(false);

        $cardSix = new Card;
        $cardSix->setId('A3');
        $cardSix->setName('Ardenner');
        $cardSix->setProperties(array(
            'size'  => 160,
            'intelligence' => 2,
            'speed' => 36,
            'price' => 4300
        ));
        $cardSix->setImage('img/ardenner.jpg');
        $cardSix->setTrumped(false);

        array_push($this->cards, $cardOne);
        array_push($this->cards, $cardTwo);
        array_push($this->cards, $cardThree);
        array_push($this->cards, $cardFour);
        array_push($this->cards, $cardFive);
        array_push($this->cards, $cardSix);
    }

    public function getCards(): array
    {
        return $this->cards;
    }

    public function shuffleCards($cards): void
    {
        shuffle($cards);
        $this->cards = $cards;
    }

    public function distributeCards($players, $shuffledCards): void
    {
        $players[0]->setCards($shuffledCards[0]);
        $players[0]->setCards($shuffledCards[1]);
        $players[0]->setCards($shuffledCards[2]);
        $players[1]->setCards($shuffledCards[3]);
        $players[1]->setCards($shuffledCards[4]);
        $players[1]->setCards($shuffledCards[5]);

        $shuffledCards[0]->setPlayerId(0);
        $shuffledCards[1]->setPlayerId(0);
        $shuffledCards[2]->setPlayerId(0);
        $shuffledCards[3]->setPlayerId(1);
        $shuffledCards[4]->setPlayerId(1);
        $shuffledCards[5]->setPlayerId(1);
    }

    public function countCards($players, $playerId): int
    {
        return count($players[$playerId]->getCards());
    }

    public function countTrumpedCards($players, $playerId): int
    {
        return count($players[$playerId]->getTrumpedCards());
    }

    public function removeFirstCardOfPlayer($players, $playerId): void
    {
        $playerCards = $players[$playerId]->getCards();
        array_shift($playerCards);

        $players[$playerId]->setCardsAfterBattle($playerCards);
    }

    public function hasEveryPlayerEnoughCards($players): bool
    {
        $continue = true;

        if (count($players[0]->getCards()) == 0 || count($players[1]->getCards()) == 0) {
            $continue = false;
        }
        return $continue;
    }

    public function playRound($players, $property): bool
    {
        $win = true;

        if (str_contains($property, 'size')) {
            if ($players[0]->chooseProperty('size') >= $players[1]->chooseProperty('size')) {
                $players[0]->setTrumpedCards($players[1]->getCards()[0], 0);
                $win = true;
            } else {
                $players[1]->setTrumpedCards($players[0]->getCards()[0], 1);
                $win = false;
            }
        }
        else if (str_contains($property, 'intelligence')) {
            if ($players[0]->chooseProperty('intelligence') >= $players[1]->chooseProperty('intelligence')) {
                $players[0]->setTrumpedCards($players[1]->getCards()[0], 0);
                $win = true;
            } else {
                $players[1]->setTrumpedCards($players[0]->getCards()[0], 1);
                $win = false;
            }
        }
        else if (str_contains($property, 'speed')) {
            if ($players[0]->chooseProperty('speed') >= $players[1]->chooseProperty('speed')) {
                $players[0]->setTrumpedCards($players[1]->getCards()[0], 0);
                $win = true;
            } else {
                $players[1]->setTrumpedCards($players[0]->getCards()[0], 1);
                $win = false;
            }
        }
        else if (str_contains($property, 'price')) {
            if ($players[0]->chooseProperty('price') >= $players[1]->chooseProperty('price')) {
                $players[0]->setTrumpedCards($players[1]->getCards()[0], 0);
                $win = true;
            } else {
                $players[1]->setTrumpedCards($players[0]->getCards()[0], 1);
                $win = false;
            }
        }

        $this->removeFirstCardOfPlayer($players, 0);
        $this->removeFirstCardOfPlayer($players, 1);

        return $win;
    }
}
