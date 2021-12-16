@echo off

echo Blocks Sound Downloader
echo ----------------------------
echo Current Directory:
echo %cd%
echo ----------------------------

:askdownload
set /P c=Download sound files? [Y/N]? 
if /I "%c%" EQU "Y" goto :download
if /I "%c%" EQU "N" goto :end
goto :askdownload

:download

powershell -Command "(New-Object Net.WebClient).DownloadFile('https://github.com/nickarora/tetris/raw/master/sounds/music.mp3', 'blocks.mp3')"

powershell -Command "(New-Object Net.WebClient).DownloadFile('https://github.com/nickarora/tetris/raw/master/sounds/pause.mp3', 'pause.mp3')"

powershell -Command "(New-Object Net.WebClient).DownloadFile('https://github.com/nickarora/tetris/raw/master/sounds/line-removal4.mp3', 'multirow.mp3')"

powershell -Command "(New-Object Net.WebClient).DownloadFile('https://github.com/nickarora/tetris/raw/master/sounds/gameover.mp3', 'gameover.mp3')"

goto vlc

:vlc

call "C:\Program Files\VideoLAN\VLC\vlc.exe" "blocks.mp3" --sout "#transcode{acodec=mpga,ab=192}:std{access=file,mux=wav,dst=blocks.wav}" vlc://quit

call "C:\Program Files\VideoLAN\VLC\vlc.exe" "pause.mp3" --sout "#transcode{acodec=mpga,ab=192}:std{access=file,mux=wav,dst=pause.wav}" vlc://quit

call "C:\Program Files\VideoLAN\VLC\vlc.exe" "multirow.mp3" --sout "#transcode{acodec=mpga,ab=192}:std{access=file,mux=wav,dst=multirow.wav}" vlc://quit

call "C:\Program Files\VideoLAN\VLC\vlc.exe" "gameover.mp3" --sout "#transcode{acodec=mpga,ab=192}:std{access=file,mux=wav,dst=gameover.wav}" vlc://quit

goto remove

:remove

del blocks.mp3
del pause.mp3
del multirow.mp3
del gameover.mp3

:end
echo Done!