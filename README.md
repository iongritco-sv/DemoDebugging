Code for DEMO on debugging in Visual Studio like a Pro

	• F5 -> F10/F11
	• Delete all breakpoints 
	
	• Pin variable value
	• Add watch and change variable value or execute code directly here + Immediate window.
	• No-Side-Effect evaluation in Immediate Window and in the Watch Window -> ,nse
	
	• Display Locals -> Debug-Window-Locals and search for local variables values
	• Search in watch by value
	• Variable json viewer

	• Break on property change -> object with properties -> right click on watch -> Break when value changes
	• Call stack
	
	• Run to cursor(right click) or ctrl+F10
	• Run execution to here -> green button
	• Move debug to a previous line manually or by using the green button and control
	• Step into a specific method in a line of code
	
	• Conditions for debugging - variable equal x(i==99)
	• Actions -> include in output the variable value with -> Step {i}
	
	• [DebuggerDisplay("{Title}")] 
	
	• IntelliTrace snapshots - when an exception is thrown, in the diagnostics tools you can back in time to a specific event and see the debug values at that point in time, like watches, locals, etc Needs to be enabled from Options->IntelliTrace->General->InteliTrace snapshots
	
	
	From <https://blog.ndepend.com/12-visual-studio-debugging-productivity-tips/> 
	• Debugging multi threading application - https://docs.microsoft.com/en-us/visualstudio/debugger/get-started-debugging-multithreaded-apps?view=vs-2019
		○ Select Debug->Window->Parallels stack
		○ Select View Threads button
		○ Select Debug->Window->Parallel watch
		○ Debug a single thread with Condintions on Filter with ThreadId