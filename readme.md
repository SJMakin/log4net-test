# log4net testbed

Example of how to include references to packages that reference log4net version 1.2.10 and >2.0.  This is unusually difficult due to the wise people at Apache changing the public key for the assembly, thereby breaking standard binding redirection.

https://logging.apache.org/log4net/release/faq.html#two-snks

## Details

This works through adding the legacy 1.2.10 assembly as content, and using binding redirection handle anything looking for this version. Then you can use any 2.x.x version. 

Bindings - note the unusual href:

```
<dependentAssembly>
	<assemblyIdentity name="log4net" publicKeyToken="1b44e1d426115821" />
	<codeBase version="1.2.10.0" href="log4net.1.2.10.dll" />
</dependentAssembly>
```
