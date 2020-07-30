const { app, BrowserWindow } = require('electron')
app.commandLine.appendSwitch('disable-renderer-backgrounding');

let win = null;;

function createWindow() {
  // Create the browser window.
  win = new BrowserWindow({
    width: 600, 
    height: 600,
    backgroundColor: '#ffffff',    
    icon: `${__dirname}/dist/XIVChecklist/assets/logo.png`
  })

  win.loadFile(`${__dirname}/dist/XIVChecklist/index.html`)

  //// uncomment below to open the DevTools.
  // win.webContents.openDevTools()

  // Event when the window is closed.
  win.on('closed', function () {
    win = null
  })
}

app.on('ready', createWindow);

app.on('window-all-closed', function() {
  if(process.platform !== 'darwin') {
    app.quit();
  }
});

app.on('activate', function() {
  if(win === null) {
    createWindow();
  }
});