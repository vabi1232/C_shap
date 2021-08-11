<?php

use Illuminate\Support\Facades\Route;

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


Route::get('/', function () {
    return view('welcome');
});

Route::get('profile/{name}','Profile@showProfile');

Route::get('home','HomeController@showWelcome');

Route::get('about',function () {
    return view('About Content');
});

Route::get('about/directions',function () {
    return 'Direction go here';
});

Route::any('submitform',function (){
    return 'Process Form';
});

Route::get('about/(theSubject)',function ($thesubject){
    return $thesubject. 'content goes here';
});
Route::get('about/{theSubject}', 'AboutController@showSubject');
Route::get('about/classes/(theSubject)',function ($theSubject){
    return " Content of $theSubject";
});

Route::get('about/classes/{TheArt}/{ThePrice}',function ($theArt,$thePrice) {
    return "The product in $theArt and $thePrice";
});

Route::get('where',function (){
    return Redirect::route('directions');
});

Route::get('/insert', function (){
    \Illuminate\Support\Facades\DB::insert('insert into posts(title,body,is_admin) values(?.?.?)', ['PHP with Laravel','Laravel is the best fremework !',0]);
    return 'DONE';
});
