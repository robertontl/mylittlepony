<?php
declare(strict_types=1);

namespace robertontl\mylittlepony\Classes\Domain\Model;

class Player
{
    /**
     * @var int
     */
    protected $id;

    /**
     * @var string
     */
    protected $name = '';

    /**
     * @var array
     */
    protected $cards = array();

    /**
     * @var array
     */
    protected $trumpedCards = array();

    public function setId(int $id): void
    {
        $this->id = $id;
    }

    public function getId(): int
    {
        return $this->id;
    }

    public function setName(string $name): void
    {
        $this->name = $name;
    }

    public function getName(): string
    {
        return $this->name;
    }

    public function setCards($card): void
    {
        array_push($this->cards, $card);
    }

    public function getCards(): array
    {
        return $this->cards;
    }

    public function setCardsAfterBattle(array $playerCards): void
    {
        $this->cards = array();

        $this->cards = $playerCards;
    }

    public function chooseProperty($property): int
    {
        return $this->cards[0]->getProperties()[$property];
    }

    public function setTrumpedCards($card, $playerId): void
    {
        $card->setPlayerId($playerId);
        $card->setTrumped(true);
        array_push($this->trumpedCards, $card);
    }

    public function getTrumpedCards(): array
    {
        return $this->trumpedCards;
    }
}
