using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace ChartsBinding
{
	// @protocol ChartAnimatorDelegate
	//[Protocol, Model]
	[BaseType(typeof(NSObject))]
	[Model]
	//[BaseType (typeof(NSObject))]
	interface ChartAnimatorDelegate
	{
	}

	#if true
	// @interface ChartViewBase : UIView <ChartDataProvider, ChartAnimatorDelegate>
	[BaseType (typeof(UIView))]
	interface ChartViewBase : ChartDataProvider, ChartAnimatorDelegate
	{
	}

	// @interface BarLineChartViewBase : ChartViewBase <BarLineScatterCandleBubbleChartDataProvider, UIGestureRecognizerDelegate>
	[BaseType (typeof(ChartViewBase))]
	interface BarLineChartViewBase : BarLineScatterCandleBubbleChartDataProvider, IUIGestureRecognizerDelegate
	{
	}

	[BaseType (typeof(BarLineChartViewBase))]
	interface BarChartView : BarChartDataProvider
	{
	}

	// @protocol BarChartDataProvider <BarLineScatterCandleBubbleChartDataProvider>
	//[Protocol, Model]
	[Model]
	interface BarChartDataProvider : BarLineScatterCandleBubbleChartDataProvider
	{
	}

	// @protocol BarLineScatterCandleBubbleChartDataProvider <ChartDataProvider>
	//[Protocol, Model]
	[BaseType (typeof(NSObject))]
	[Model]
	interface BarLineScatterCandleBubbleChartDataProvider : ChartDataProvider
	{
	}

	// @protocol ChartDataProvider
	//[Protocol, Model]
	[BaseType (typeof(NSObject))]
	[Model]
	interface ChartDataProvider
	{
	}
	#endif
}

