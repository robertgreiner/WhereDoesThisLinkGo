WhereDoesThisLinkGo?!
==========

ASP .NET MVC 4 application that takes a shortened URL and displays the final destination.

Usage
-----

Enter the shortened URL into the text field and submit.

Go to [wheredoesthislinkgo.com](http://wheredoesthislinkgo.com) for a live implementation.

Code
----

    //using System.Net
    var request = (HttpWebRequest)WebRequest.Create(url);
    var response = (HttpWebResponse)request.GetResponse();
                return response.ResponseUri;    

Copyright
---------

Copyright (c) 2012 [Robert Greiner](http://robertgreiner.com). See LICENSE for details.
