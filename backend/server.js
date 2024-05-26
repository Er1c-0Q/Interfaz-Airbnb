// server.js
const express = require('express');
const sql = require('mssql');
const dbConfig = require('./dbconfig');

const app = express();
const port = 3000;
