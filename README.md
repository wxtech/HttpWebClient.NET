HttpWebClient.NET
=================

ASP.NET Simple HttpWebClient , POST or GET Html Form Data 


Example No.1:
==================== REQUEST BEGIN ====================
++++++++++ Request Line Info ++++++++++
POST http://localhost:53090/upload/uploadfile HTTP/1.1
++++++++++ Request Header Info ++++++++++
Referer=http://localhost
User-Agent=Mozilla/5.0 (Windows NT 6.1; WOW64; rv:33.0) Gecko/20100101 Firefox/3
3.0
Content-Type=multipart/form-data; boundary=---------------------------8d1d6ed0a2
635d8
++++++++++ Request Body Info ++++++++++
-----------------------------8d1d6ed0a2635d8
Content-Disposition: form-data; name="StorageFile.Title"

title01
-----------------------------8d1d6ed0a2635d8
Content-Disposition: form-data; name="StorageFile.Summary"

summary01
-----------------------------8d1d6ed0a2635d8
Content-Disposition: form-data; name="filedata"; filename="001.jpg"
Content-Type: application/octet-stream
Content-Transfer-Encoding: binary

...binary data...
==================== REQUEST END ====================


Example No.2:
==================== REQUEST BEGIN ====================
++++++++++ Request Line Info ++++++++++
POST http://localhost:53090/passport/logon HTTP/1.1
++++++++++ Request Header Info ++++++++++
User-Agent=Mozilla/5.0 (Windows NT 6.1; WOW64; rv:33.0) Gecko/20100101 Firefox/3
3.0
Content-Type=application/x-www-form-urlencoded
++++++++++ Request Body Info ++++++++++
LogonInfo.ValidateCode=gvzwb&LogonInfo.User.Username=sanxia123&LogonInfo.User.Pa
ssword=Yc123703&LogonInfo.IsPersistentCookie=false
==================== REQUEST END ====================


Example No.3:
==================== REQUEST BEGIN ====================
++++++++++ Request Line Info ++++++++++
GET http://localhost:53090/content/oauth.html HTTP/1.1
++++++++++ Request Header Info ++++++++++
User-Agent=Mozilla/5.0 (Windows NT 6.1; WOW64; rv:33.0) Gecko/20100101 Firefox/3
3.0
++++++++++ Request Body Info ++++++++++
a=1
==================== REQUEST END ====================


