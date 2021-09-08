<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\ProductController;
/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/


//
//Route::view('/products','products');
//Route::post('/save',[ProductController::class,'save'])->name('save.product');
Route::get('/',[ProductController::class,'index']);
Route::post('index',[\App\Http\Controllers\ProductController::class,'store'])->name('store');
Route::post('/',[\App\Http\Controllers\ProductController::class,'index'])->name('index');
Route::get('/',[\App\Http\Controllers\ProductController::class,'getDashboard']);
