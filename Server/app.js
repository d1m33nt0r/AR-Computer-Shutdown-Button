var child_process = require('child_process');
const express = require("express");

const app = new express();

app.get("/", (req, res) => {
    child_process.exec('off.bat')
    res.send(true)
})

app.listen(4000)