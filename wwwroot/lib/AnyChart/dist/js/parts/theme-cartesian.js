if(!_.theme_cartesian){_.theme_cartesian=1;(function($){var B4=function(){return $.zs(this.x)},eqa=function(){return $.zs(this.tickValue)};
$.ra($.fa.anychart.themes.defaultTheme,{cartesian:{defaultSeriesType:"line",defaultSeriesSettings:{base:{xMode:"ordinal"}}},area:{defaultSeriesType:"area",tooltip:{displayMode:"union"},interactivity:{hoverMode:"by-x"}},bar:{isVertical:!0,defaultSeriesType:"bar",defaultXAxisSettings:{orientation:"left"},defaultYAxisSettings:{orientation:"bottom"},scales:[{type:"ordinal",inverted:!0},{type:"linear",stackDirection:"reverse"}],tooltip:{displayMode:"single",position:"right-center",anchor:"left-center"},
xScroller:{orientation:"left",inverted:!0},yScroller:{orientation:"bottom",inverted:!1}},column:{defaultSeriesType:"column",tooltip:{displayMode:"single",position:"center-top",anchor:"center-bottom",offsetX:0,offsetY:10},scales:[{type:"ordinal"},{type:"linear",softMinimum:0}]},line:{defaultSeriesType:"line",tooltip:{displayMode:"union"},interactivity:{hoverMode:"by-x"}},box:{defaultSeriesType:"box"},financial:{defaultSeriesType:"candlestick",defaultSeriesSettings:{candlestick:{tooltip:{titleFormat:B4},
normal:{labels:{format:B4}}},ohlc:{tooltip:{titleFormat:B4},normal:{labels:{format:B4}}}},xAxes:[{labels:{format:eqa},minorLabels:{format:eqa}}],scales:[{type:"date-time"},{type:"linear"}]},candlestick:{defaultSeriesType:"candlestick"},ohlc:{defaultSeriesType:"ohlc"},verticalLine:{isVertical:!0,defaultSeriesType:"line",defaultXAxisSettings:{orientation:"left"},defaultYAxisSettings:{orientation:"bottom"},scales:[{type:"ordinal",inverted:!0},{type:"linear"}],tooltip:{displayMode:"union"},interactivity:{hoverMode:"by-x"},
xScroller:{orientation:"left",inverted:!0},yScroller:{orientation:"bottom",inverted:!1}},verticalArea:{isVertical:!0,defaultSeriesType:"area",defaultXAxisSettings:{orientation:"left"},defaultYAxisSettings:{orientation:"bottom"},scales:[{type:"ordinal",inverted:!0},{type:"linear"}],tooltip:{displayMode:"union"},interactivity:{hoverMode:"by-x"},xScroller:{orientation:"left",inverted:!0},yScroller:{orientation:"bottom",inverted:!1}}});}).call(this,$)}
