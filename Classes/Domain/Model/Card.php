<?php
declare(strict_types=1);

namespace robertontl\mylittlepony\Classes\Domain\Model;

class Card
{
    /**
     * @var string
     */
    protected $id = '';

    /**
     * @var string
     */
    protected $name = '';

    /**
     * @var array
     */
    protected $properties = array();

    /**
     * @var int
     */
    protected $playerId;

    /**
     * @var string
     */
    protected $image = '';

    /**
     * @var bool
     */
    protected $trumped;

    public function setId(string $id): void
    {
        $this->id = $id;
    }

    public function getId(): string
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

    public function setProperties(array $properties): void
    {
        $this->properties = $properties;
    }

    public function getProperties(): array
    {
        return $this->properties;
    }

    public function setPlayerId(int $playerId): void
    {
        $this->playerId = $playerId;
    }

    public function getPlayerId(): int
    {
        return $this->playerId;
    }

    public function setImage(string $image): void
    {
        $this->image = $image;
    }

    public function getImage(): string
    {
        return $this->image;
    }

    public function setTrumped(bool $trumped): void
    {
        $this->trumped = $trumped;
    }

    public function getTrumped(): bool
    {
        return $this->trumped;
    }
}
