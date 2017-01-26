﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using App.Metrics.Core;
using App.Metrics.Core.Abstractions;
using App.Metrics.Meter;

namespace App.Metrics.Timer
{
    /// <summary>
    ///     <para>
    ///         Timer metric types are essentially a special case of <see cref="Histogram" />
    ///     </para>
    ///     <para>
    ///         As well as providing a <see cref="Histogram" /> of the duration of a type of event, timers also provide a
    ///         <see cref="MeterMetric" /> of the rate of the events occurrence.
    ///     </para>
    ///     <para>
    ///         Like <see cref="Histogram" />s, timers also allow us to track user values, where for all user values provided
    ///         the min, max and last user value values is recorded.
    ///     </para>
    /// </summary>
    /// <seealso cref="Metric" />
    public sealed class TimerMetric : Metric
    {
        public long ActiveSessions { get; set; }

        public long Count { get; set; }

        public string DurationUnit { get; set; }

        public HistogramData Histogram { get; set; }

        public RateData Rate { get; set; }

        public string RateUnit { get; set; }

        public long TotalTime { get; set; }

        public sealed class HistogramData
        {
            public string LastUserValue { get; set; }

            public double LastValue { get; set; }

            public double Max { get; set; }

            public string MaxUserValue { get; set; }

            public double Mean { get; set; }

            public double Median { get; set; }

            public double Min { get; set; }

            public string MinUserValue { get; set; }

            public double Percentile75 { get; set; }

            public double Percentile95 { get; set; }

            public double Percentile98 { get; set; }

            public double Percentile99 { get; set; }

            public double Percentile999 { get; set; }

            public int SampleSize { get; set; }

            public double StdDev { get; set; }
        }

        public sealed class RateData
        {
            public double FifteenMinuteRate { get; set; }

            public double FiveMinuteRate { get; set; }

            public double MeanRate { get; set; }

            public double OneMinuteRate { get; set; }
        }
    }
}