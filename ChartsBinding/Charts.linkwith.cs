using ObjCRuntime;

[assembly: LinkWith (
	"Charts.a",
	LinkTarget.ArmV7,
	SmartLink = true,
	ForceLoad = true,
	Frameworks="CoreGraphics UIKit Foundation",
	LinkerFlags="-lxml2 -ObjC")]
