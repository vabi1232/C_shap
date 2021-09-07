<?php

namespace App\Http\Controllers;

use App\Models\Lists;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
class ListController extends Controller
{
    public function Commit(Request $request){
        $list = new Lists;
        $list->CMND=$request->CMND;
        $list->hovaten=$request->hovaten;
        $list->ngaythangnamsinh=$request->ngaythangnamsinh;
        $list->diachi=$request->diachi;
        $list->sdt=$request->sdt;
        $list->tiensudiung=$request->tiensudiung;
        $list->save();

        return redirect('/');


    }

    public  function  Search(Request $request){
            $search = $request->get('search');
        $list = DB::table('list')->where('hovaten','like','%'.$search.'%')->paginate(10);

        return view('index',compact('list'));
    }
    public function  View(){
        $data =  Lists::all();
        return view('index',['list'=>$data]);
    }
}
