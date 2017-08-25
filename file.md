# The idea.
Since i’ve started learning on Linux academy there has been something missing. Real scenario troubleshooting. This is mainly focused on RHCSA and RHCE courses.

The idea that in every week or so Linux Academy uploads a virtual machine (or machines, maybe server and a client)  that is not working properly. This could of course be a lab server hosted by Linux Academy as well.

The goal for the student is to resolve the issues that affect the server.

## Some examples might be:

* There is a problem with Apache web server, the server was rebooted because it had been running for over a year without a reboot. It seems after the reboot the server is unable to serve content. What happened when the server was rebooted? And how can you fix it?

	* Possible solutions
	SELinux might be enabled after the reboot, the apache server is unable to execute into the filesystem or read the files, might be a ACL problem. A faulty rewrite rule is 		redirecting all calls to some location. 

* There is a database running a server, there is a firewall running on the server as well. The client machine has lost all connection to the database server. There is also a problem with the database backup, it has not been backed up for several days.

	* Possible solutions.
	The firewall rule is no longer in effect on the server or has been changed so that it denies all connections to port 3306. 

	How is the database backed up? Is it a cron job? If so, where is it stored and can you find the log to see what the problem is. This issue might be caused by insufficient space 		on the filesystem and we need to expand the LVM. There might be a wrong password for the database in the cron script. How can we safely use the password in a cron script to 		backup the database.

The reason behind this is to use the skills we have learned here at Linux Academy to tackle real life scenarios and to help us become better at our jobs or to prepare ourselves for the exams.

There are many more possibilities, DNS problems, NTP problems, maybe some JAVA application is always running out of memory, how can we fix that. User problems and so on.
