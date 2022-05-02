# Tracing the Power Error for C#
This repository traces the * Assertion at mini-codegen.c:1096, condition `! is_global_ireg (hreg)' not met Error


### Steps to reproduce 
- Login on power Openshift instance
- Build Container from Dockerfile
- Run Container


### Important notices i made while creating the minimal example
- The error occures before any C# code from the DLL is exected!, I made a Console.WriteLine("This one is not printed on the stdout") at the entrypoint of the Method to demonstrate this

- Dependency ZeroFromatter can be found here : https://github.com/alexinea/Alexinea.ZeroFormatter/  it is a valid nuget package. We are using alexineas version, since the original Zeroformatter had a Issue when running on DotnetCore 3.1 we encounterd https://github.com/neuecc/ZeroFormatter/issues/112
- Source code is located in Skm.Holo.zip, just unzip to see.
- While i made a whole lot of testruns, one time i encounterd a similar error on the build unfortunatly i was not able to reproduce the error or copy it.
- Description: On build time (while the container was build) after the ```RUN nuget restore Skm.Holo.sln``` command the listing stopped at   
  ```GET https://api.nuget.org/v3-flatcontainer/system.runtime/index.json
  GET https://api.nuget.org/v3-flatcontainer/system.buffers/index.json
  GET https://api.nuget.org/v3-flatcontainer/system.runtime.extensions/index.json
  GET https://api.nuget.org/v3-flatcontainer/system.io/index.json
  GET https://api.nuget.org/v3-flatcontainer/system.collections/index.json
  GET https://api.nuget.org/v3-flatcontainer/system.io.compression/index.json
printed an error very simular to the Nativ Crash Reporting: 
last package touched was system.io.compression!
I assume, that the error is linked to System.IO.Compresssion but it is more like a gut feeling

### Contact
mhermelschmidt@skm-informatik.com

## Output on x86

```hermel@hermel-laptop ~/D/TracingPowerError (main)> docker run 
minimalcsharp:latest                                                                                                             (base) 
before progam
This one is not printed on the stdout
outta program
```

---

## Output on Power 

```before progam
* Assertion at mini-codegen.c:1096, condition `! is_global_ireg (hreg)' not met


=================================================================
	Native Crash Reporting
=================================================================
Got a SIGABRT while executing native code. This usually indicates
a fatal error in the mono runtime or one of the native libraries
used by your application.
=================================================================

=================================================================
	Native stacktrace:
=================================================================
	0x120c09cec - mono :
	0x120c09f88 - mono :
	0x120bc98e4 - mono :
	0x120c08ba4 - mono :
	0x7fff904b04d8 - linux-vdso64.so.1 : __kernel_sigtramp_rt64
	0x7fff90094228 - /lib/powerpc64le-linux-gnu/libc.so.6 : gsignal
	0x7fff9007458c - /lib/powerpc64le-linux-gnu/libc.so.6 : abort
	0x120f5ad78 - mono : monoeg_assert_abort
	0x120f2fa78 - mono :
	0x120f29c38 - mono :
	0x120f5abd8 - mono :
	0x120f5b2c4 - mono : monoeg_assertion_message
	0x120f5b320 - mono : mono_assertion_message
	0x120c6ad18 - mono :
	0x120c6ed40 - mono :
	0x120c0f5a8 - mono :
	0x120c1191c - mono :
	0x120c12c28 - mono :
	0x120b830ec - mono :
	0x120bce248 - mono :
	0x120bceed8 - mono :
	0x7fff8ff401c4 - Unknown
	0x7fff8fd43f04 - Unknown
	0x7fff8fd440ac - Unknown
	0x120b84718 - mono :
	0x120dffce8 - mono :
	0x120e04d9c - mono :
	0x120b8cf70 - mono : mono_jit_exec
	0x120b90b78 - mono : mono_main
	0x120b76d38 - mono :
	0x7fff90074bf8 - /lib/powerpc64le-linux-gnu/libc.so.6 :
	0x7fff90074de4 - /lib/powerpc64le-linux-gnu/libc.so.6 : __libc_start_main

=================================================================
	Telemetry Dumper:
=================================================================
Pkilling 0x140735568867648x from 0x140735614635024x
Could not exec mono-hang-watchdog, expected on path '/etc/../bin/mono-hang-watchdog' (errno 2)
Entering thread summarizer pause from 0x140735614635024x
Finished thread summarizer pause from 0x140735614635024x.
Failed to create breadcrumb file (null)/crash_hash_0x14f1ed9ff

Waiting for dumping threads to resume

=================================================================
	Basic Fault Address Reporting
=================================================================
Memory around native instruction pointer (0x7fff90094228):0x7fff90094218  02 00 60 38 00 00 a0 38 08 00 c0 38 02 00 00 44  ..`8...8...8...D
0x7fff90094228  26 00 00 7c 28 01 21 e9 f0 8f 4d e9 79 52 29 7d  &..|(.!...M.yR)}
0x7fff90094238  00 00 40 39 78 f3 c3 7f 38 00 82 40 50 01 21 38  ..@9x...8..@P.!8
0x7fff90094248  10 00 01 e8 e8 ff a1 eb f0 ff c1 eb f8 ff e1 eb  ................

=================================================================
	Managed Stacktrace:
=================================================================
	  at <unknown> <0xffffffff>
	  at actual_example.Program:Main <0x0002c>
	  at <Module>:runtime_invoke_void_object <0x00160>
=================================================================

=================================================================
	External Debugger Dump:
=================================================================
mono_gdb_render_native_backtraces not supported on this platform, unable to find gdb or lldb
/init.sh: line 4:     9 Aborted                 (core dumped) mono Program.exe
outta program ```




