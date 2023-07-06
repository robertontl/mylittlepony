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
        <div class="container text-center">
            <div class="row justify-content-center" style="margin-top: 25px;">
                <img src="img/mylittlepony-v2.png" style="width: 30%; height: 30%; border: 1px solid; padding-left: 0px; padding-right: 0px;" />
            </div>
            <div class="row justify-content-center" style="margin-top: 25px;">
                    <div class="col-6">
                        <div class="mb-3">
                            <form method="post" action="start.php">
                                <label for="player" class="form-label"><h6>Name Spieler 1</h6></label>
                                <input type="text" class="form-control" id="player" name="player" required />
                                <div id="playerHelp" class="form-text" style="margin-top: 10px;">Bitte hier deinen Spielernamen angeben.</div>
                                <input type="hidden" name="modus" value="start" />
                                <button type="submit" class="btn btn-primary" style="margin-top: 10px;">Start MyLittlePony</button>
                            </form>
                        </div>
                    </div>      
                </form>
            </div>
        </div>
    </body>
</html>
