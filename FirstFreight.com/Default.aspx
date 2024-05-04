<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstFreight.Default" %>

<%@ Register Src="~/_usercontrols/nav.ascx" TagPrefix="uc1" TagName="nav" %>
<%@ Register Src="~/_usercontrols/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>First Freight | CRM for Logistics Sales</title>
    <meta name="description" content="First Freight CRM is the easiest way to manage your freight sales activities and improve results!" />
    <link href="css/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="css/animate.min.css" rel="stylesheet" />
    <link href="css/style-18-jul-2023.css" rel="stylesheet" />
    <!-- Google Tag Manager -->
    <script>
        (function (w, d, s, l, i) {
            w[l] = w[l] || [];
            w[l].push({
                'gtm.start': new Date().getTime(),
                event: 'gtm.js',
            });
            var f = d.getElementsByTagName(s)[0],
                j = d.createElement(s),
                dl = l != 'dataLayer' ? '&l=' + l : '';
            j.async = true;
            j.src = 'https://www.googletagmanager.com/gtm.js?id=' + i + dl;
            f.parentNode.insertBefore(j, f);
        })(window, document, 'script', 'dataLayer', 'GTM-PGLRK9H');
    </script>
    <!-- End Google Tag Manager -->
    <!--Start Sentry-->
    <script src="https://js.sentry-cdn.com/59d8d19b8d5a4e188e7c51a3b26a78d4.min.js" crossorigin="anonymous" aria-label="Sentry"></script>
    <!--End Sentry-->
    <!--Start Speed-curve-->
    <script>LUX = function () { function n() { return Date.now ? Date.now() : +new Date } var r, e = n(), t = window.performance || {}, a = t.timing || { navigationStart: (null === (r = window.LUX) || void 0 === r ? void 0 : r.ns) || e }; function o() { return t.now ? t.now() : n() - a.navigationStart } LUX = { ac: [], addData: function (n, r) { return LUX.cmd(["addData", n, r]) }, cmd: function (n) { return LUX.ac.push(n) }, init: function () { return LUX.cmd(["init"]) }, mark: function () { for (var n = [], r = 0; r < arguments.length; r++)n[r] = arguments[r]; if (t.mark) return t.mark.apply(t, n); var e = n[0], a = n[1] || {}; void 0 === a.startTime && (a.startTime = o()); LUX.cmd(["mark", e, a]) }, markLoadTime: function () { return LUX.cmd(["markLoadTime", o()]) }, measure: function () { for (var n = [], r = 0; r < arguments.length; r++)n[r] = arguments[r]; if (t.measure) return t.measure.apply(t, n); var e, a = n[0], i = n[1], u = n[2]; e = "object" == typeof i ? n[1] : { start: i, end: u }; e.duration || e.end || (e.end = o()); LUX.cmd(["measure", a, e]) }, send: function () { return LUX.cmd(["send"]) }, ns: e }; var i = LUX; if (window.LUX_ae = [], window.addEventListener("error", (function (n) { window.LUX_ae.push(n) })), window.LUX_al = [], "function" == typeof PerformanceObserver && "function" == typeof PerformanceLongTaskTiming) { var u = new PerformanceObserver((function (n) { for (var r = n.getEntries(), e = 0; e < r.length; e++)window.LUX_al.push(r[e]) })); try { u.observe({ type: "longtask" }) } catch (n) { } } return i }();</script>
    <script src="https://cdn.speedcurve.com/js/lux.js?id=4405189326" defer crossorigin="anonymous" aria-label="SpeedCurve"></script>
    <!--End Speed-curve-->
    <!--Start LogRocket-->
    <script src="https://cdn.lr-intake.com/LogRocket.min.js" crossorigin="anonymous" aria-label="LogRocket"></script>
    <script>window.LogRocket && window.LogRocket.init('firstfreightcom/wwwfirstfreightcom');</script>
    <!--Emd LogRocket-->
    <!--AppInsight Javascript-->
    <script type="text/javascript">
        !(function (cfg) { function e() { cfg.onInit && cfg.onInit(i) } var S, u, D, t, n, i, C = window, x = document, w = C.location, I = "script", b = "ingestionendpoint", E = "disableExceptionTracking", A = "ai.device."; "instrumentationKey"[S = "toLowerCase"](), u = "crossOrigin", D = "POST", t = "appInsightsSDK", n = cfg.name || "appInsights", (cfg.name || C[t]) && (C[t] = n), i = C[n] || function (l) { var d = !1, g = !1, f = { initialize: !0, queue: [], sv: "7", version: 2, config: l }; function m(e, t) { var n = {}, i = "Browser"; function a(e) { e = "" + e; return 1 === e.length ? "0" + e : e } return n[A + "id"] = i[S](), n[A + "type"] = i, n["ai.operation.name"] = w && w.pathname || "_unknown_", n["ai.internal.sdkVersion"] = "javascript:snippet_" + (f.sv || f.version), { time: (i = new Date).getUTCFullYear() + "-" + a(1 + i.getUTCMonth()) + "-" + a(i.getUTCDate()) + "T" + a(i.getUTCHours()) + ":" + a(i.getUTCMinutes()) + ":" + a(i.getUTCSeconds()) + "." + (i.getUTCMilliseconds() / 1e3).toFixed(3).slice(2, 5) + "Z", iKey: e, name: "Microsoft.ApplicationInsights." + e.replace(/-/g, "") + "." + t, sampleRate: 100, tags: n, data: { baseData: { ver: 2 } }, ver: 4, seq: "1", aiDataContract: undefined } } var h = -1, v = 0, y = ["js.monitor.azure.com", "js.cdn.applicationinsights.io", "js.cdn.monitor.azure.com", "js0.cdn.applicationinsights.io", "js0.cdn.monitor.azure.com", "js2.cdn.applicationinsights.io", "js2.cdn.monitor.azure.com", "az416426.vo.msecnd.net"], k = l.url || cfg.src; if (k) { if ((n = navigator) && (~(n = (n.userAgent || "").toLowerCase()).indexOf("msie") || ~n.indexOf("trident/")) && ~k.indexOf("ai.3") && (k = k.replace(/(\/)(ai\.3\.)([^\d]*)$/, function (e, t, n) { return t + "ai.2" + n })), !1 !== cfg.cr) for (var e = 0; e < y.length; e++)if (0 < k.indexOf(y[e])) { h = e; break } var i = function (e) { var a, t, n, i, o, r, s, c, p, u; f.queue = [], g || (0 <= h && v + 1 < y.length ? (a = (h + v + 1) % y.length, T(k.replace(/^(.*\/\/)([\w\.]*)(\/.*)$/, function (e, t, n, i) { return t + y[a] + i })), v += 1) : (d = g = !0, o = k, c = (p = function () { var e, t = {}, n = l.connectionString; if (n) for (var i = n.split(";"), a = 0; a < i.length; a++) { var o = i[a].split("="); 2 === o.length && (t[o[0][S]()] = o[1]) } return t[b] || (e = (n = t.endpointsuffix) ? t.location : null, t[b] = "https://" + (e ? e + "." : "") + "dc." + (n || "services.visualstudio.com")), t }()).instrumentationkey || l.instrumentationKey || "", p = (p = p[b]) ? p + "/v2/track" : l.endpointUrl, (u = []).push((t = "SDK LOAD Failure: Failed to load Application Insights SDK script (See stack for details)", n = o, r = p, (s = (i = m(c, "Exception")).data).baseType = "ExceptionData", s.baseData.exceptions = [{ typeName: "SDKLoadFailed", message: t.replace(/\./g, "-"), hasFullStack: !1, stack: t + "\nSnippet failed to load [" + n + "] -- Telemetry is disabled\nHelp Link: https://go.microsoft.com/fwlink/?linkid=2128109\nHost: " + (w && w.pathname || "_unknown_") + "\nEndpoint: " + r, parsedStack: [] }], i)), u.push((s = o, t = p, (r = (n = m(c, "Message")).data).baseType = "MessageData", (i = r.baseData).message = 'AI (Internal): 99 message:"' + ("SDK LOAD Failure: Failed to load Application Insights SDK script (See stack for details) (" + s + ")").replace(/\"/g, "") + '"', i.properties = { endpoint: t }, n)), o = u, c = p, JSON && ((r = C.fetch) && !cfg.useXhr ? r(c, { method: D, body: JSON.stringify(o), mode: "cors" }) : XMLHttpRequest && ((s = new XMLHttpRequest).open(D, c), s.setRequestHeader("Content-type", "application/json"), s.send(JSON.stringify(o)))))) }, a = function (e, t) { g || setTimeout(function () { !t && f.core || i() }, 500), d = !1 }, T = function (e) { var n = x.createElement(I), e = (n.src = e, cfg[u]); return !e && "" !== e || "undefined" == n[u] || (n[u] = e), n.onload = a, n.onerror = i, n.onreadystatechange = function (e, t) { "loaded" !== n.readyState && "complete" !== n.readyState || a(0, t) }, cfg.ld && cfg.ld < 0 ? x.getElementsByTagName("head")[0].appendChild(n) : setTimeout(function () { x.getElementsByTagName(I)[0].parentNode.appendChild(n) }, cfg.ld || 0), n }; T(k) } try { f.cookie = x.cookie } catch (p) { } function t(e) { for (; e.length;)!function (t) { f[t] = function () { var e = arguments; d || f.queue.push(function () { f[t].apply(f, e) }) } }(e.pop()) } var r, s, n = "track", o = "TrackPage", c = "TrackEvent", n = (t([n + "Event", n + "PageView", n + "Exception", n + "Trace", n + "DependencyData", n + "Metric", n + "PageViewPerformance", "start" + o, "stop" + o, "start" + c, "stop" + c, "addTelemetryInitializer", "setAuthenticatedUserContext", "clearAuthenticatedUserContext", "flush"]), f.SeverityLevel = { Verbose: 0, Information: 1, Warning: 2, Error: 3, Critical: 4 }, (l.extensionConfig || {}).ApplicationInsightsAnalytics || {}); return !0 !== l[E] && !0 !== n[E] && (t(["_" + (r = "onerror")]), s = C[r], C[r] = function (e, t, n, i, a) { var o = s && s(e, t, n, i, a); return !0 !== o && f["_" + r]({ message: e, url: t, lineNumber: n, columnNumber: i, error: a, evt: C.event }), o }, l.autoExceptionInstrumented = !0), f }(cfg.cfg), (C[n] = i).queue && 0 === i.queue.length ? (i.queue.push(e), i.trackPageView({})) : e(); })({
            src: "https://js.monitor.azure.com/scripts/b/ai.3.gbl.min.js",
            // name: "appInsights",
            // ld: 0,
            // useXhr: 1,
            crossOrigin: "anonymous",
            // onInit: null,
            // cr: 0,
            cfg: { // Application Insights Configuration
                connectionString: "InstrumentationKey=3dab33c1-a8b7-4f2c-9633-a8500445b419;IngestionEndpoint=https://eastus-8.in.applicationinsights.azure.com/;LiveEndpoint=https://eastus.livediagnostics.monitor.azure.com/"
            }
        });
    </script>
    <!--AppInsight Javascript End-->
    <link
        href="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAMAAABg3Am1AAABXFBMVEUAAAApmtVDvuw9t+kNdbxFwvENdbxFw/FFw/FFwvFFwvAjkc8pmtUNdrwhj84Ndbwpm9ZFw/Epm9YNdrwpmtYNdrwpm9YNdbtFw/ENdbwpmtYqm9YpmtUNdbxFw/FFw/FBve0omNREwfBFwvANdbtFw/Epm9YNdbtFw/FFwvANdbsNdbxFw/ENdbspmtYNdbxFwvBFwvAOdrwpm9YpmtYRe8ApmtVCve0NdbxGw/ENdbwpmtVFw/Eqm9YpmtVFwvAqm9YOdrxFwvBFwvApmtYNdbsNdbxFwvAqm9YomtUNdbsqm9YomdUNdbtFw/ENdbwOdrwNdbsomdUNdbwOdrwpmtUqm9ZGw/FGw/Eqm9Yqm9ZGw/FFwvANdbspmtUqm9ZGw/FFwvApmtUNdbsqm9YXgcRFwvBGw/EpmtUOdrwqm9YpmtUqm9ZGxPEOdrxGw/Epm9YNdbsOdrxFwvDKG5DKAAAAb3RSTlMA/gMIrTn38b5FLhwVCwf9+/f08O/q5tjUybOZVUM/IhkQDefh3dK4taunjnRwaWhkWk5LPjUnFRL758fDwbu6trKvn5+SioaFhYNjXV1PRz86LS0l29jMyb6mop2bmIeDgX18em9sZ2JgNzIxGhhLD0F9AAACOklEQVRIx63TZ1daQRAG4Hf3UgUBpRilCPYeFRCsUWNvsaT33pNt//+czMbPC/ee4/N5dmenLO5K6uovgjl500Yg9/U+AvmUVpcIoDekVQgBPMprvQb/2jNKqTUsBChZaR3iL99xnw+KaKV02duTJfhxM0YJ1CRqm3I9ge4SA5oqyN5ghUnZ8NHRQaXJObDHGDv10AUP2fv1QQoNipelxTg6O0grstNGLcckY9fDpvOJ84jt6OBjeC+oAjZU+2NGh+HWHFN0YKyJVFGS/hIujHjVsWCSLQOfM5JKKHqYEuaeO8WssgmWgbN+SSYSqESFGQ/D4UpZ8xyNHN0vc7/BY4Iy9MBhwBY804tEQRJWBw5XjREbvMPKqQFq0LptkFwAlqKUoG/OmYDuj/wA3krrGAiPU7x45hp2Oavpm/Vigdn3FDmGnxshRLQCh5OI1vlL/Cr8n1gSIzFjfYNLSOl0CHzIbsTENWgCgir+wOEyqXRkGd9pAixXAl4bQS96OAKnHa3ySG5TAZkiMNcnSKwKt9m0mkTdJniaQmXUNsiOzG05q/ZxxBjL1FGN2fjRODoaVLMjW9SiIfD3Nr5vEZ2V1UzrCWVYQThqqEGH6GY+Xy0wtgVv107sAUc3fP7LhGSnCNv7oy340NyW9KJpO4EL+ME/ykzSs/G7Hnz5WZDJit3pMHw6YomvtyvhU23zbE6Y1SX4ljxedOyES6qHZtBCEONi2kMQSybgAS+2UUUgPVNxBBOOcwTCPdyRf41qkynKpnkFAAAAAElFTkSuQmCC"
        rel="icon"
        type="image/x-icon" />
</head>
<body id="page-top" class="home-page">
    <!-- Google Tag Manager (noscript) -->
    <noscript>
        <iframe
            src="https://www.googletagmanager.com/ns.html?id=GTM-PGLRK9H"
            height="0"
            width="0"
            style="display: none; visibility: hidden"></iframe>
    </noscript>
    <!-- End Google Tag Manager (noscript) -->
    <!-- Navigation -->
    <uc1:nav runat="server" />
    <div id="container">
        <!-- CRM for Logistics Section -->
        <div class="header-banner" id="crm">
            <div class="bleed-container --banner" style="padding-top: 60px;">
                <div class="banner-image bleed bleed-left wow fadeInLeft">
                    <img class="hero-img contain" src="/images/hero-img.png" alt="hero-banner" />
                </div>
                <div class="bleed-nobleed banner-text-wrapper wow zoomIn">
                    <h1>A CRM Built for Freight Forwarders and Global Logistics Providers</h1>
                    <ul class="banner_ul">
                        <li>
                            <div class="banner_ul--tick">
                                <img src="images/success-tick-blue-icon.svg" alt="">
                            </div>
                            Gain complete sales visibility and control across all modes and 3PL services 
                        </li>
                        <li>
                            <div class="banner_ul--tick">
                                <img src="images/success-tick-blue-icon.svg" alt="">
                            </div>
                            Cloud-based freight CRM that works on desktop and mobile  
                        </li>
                        <li>
                            <div class="banner_ul--tick">
                                <img src="images/success-tick-blue-icon.svg" alt="">
                            </div>
                            Covers sea, air, road, rail, logistics, brokerage
                        </li>
                    </ul>
                    <div class="header-banner-logos">
                        <div class="header-banner-logos--item">
                            <img alt="wca-vendors" src="/images/banner-logos/wca-vendors.png" />
                        </div>
                        <div class="doted-border"></div>
                        <div class="header-banner-logos--item">
                            <img alt="wca-vendors" src="/images/banner-logos/global.png" />
                        </div>
                        <div class="doted-border"></div>
                        <div class="header-banner-logos--item">
                            <img alt="wca-vendors" src="/images/banner-logos/fta.png" />
                        </div>
                        <div class="doted-border"></div>
                        <div class="header-banner-logos--item">
                            <img alt="wca-vendors" src="/images/banner-logos/ciffa.png" />
                        </div>
                    </div>
                    <div class="startTrialContainer">
                        <button id="startTrial" class="btn-primary large" onclick="window.open('/FreeTrialSignup.aspx','_blank')"
                            type="button">
                            Start your Free Trial  
                        </button>
                        <span>(No Credit Card Required)</span>
                    </div>
                </div>
            </div>
        </div>
        <!-- trusted by freight sales teams -->
        <section class="section-trusted-freight-teams">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <h3>Trusted by Freight Sales Teams Worldwide</h3>
                    </div>
                </div>
                <div class="row client-list">
                    <div class="client-list-item col-12">
                        <img src="/images/customer-logos/kwe.png"  alt=""/>
                        <img src="/images/customer-logos/ktl.png"  alt=""/>
                        <img src="/images/customer-logos/pil.png"  alt=""/>
                    </div>
                </div>
            </div>
        </section>
        <div class="background-overlay-big-sec">
            <img src="/images/home-pages-sec2-overlay.svg" class="language-bg" alt="language-bg">
            <!-- comparison -->
            <section id="freight-crm" class="section-comparison crm-design light-white-bg">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 text-center">
                            <div class="section-label">CRM Comparison </div>
                            <h2 class="section-title">Don't Settle for a Catch-All Solution. </h2>
                            <h2 class="section-title">
                                <span>Get the CRM that's</span>
                                <span class="section-title bluebg">Engineered for the Freight Industry</span>
                            </h2>
                        </div>
                    </div>
                    <div class="row supported-box justify-content-center">
                        <div class="col-6  col-sm-2">
                            <div class="box-wrap">
                                <div>
                                    <img src="/images/Sea.svg" alt="sea" />
                                    <h3>Sea</h3>
                                </div>
                            </div>
                        </div>
                        <div class="col-6  col-sm-2">
                            <div class="box-wrap">
                                <div>
                                    <img src="/images/Air.svg" alt="air" />
                                    <h3>Air</h3>
                                </div>
                            </div>
                        </div>
                        <div class="col-6  col-sm-2">
                            <div class="box-wrap">
                                <div>
                                    <img src="/images/Logistics.svg" alt="logistics" />
                                    <h3>Road</h3>
                                </div>
                            </div>
                        </div>
                        <div class="col-6  col-sm-2">
                            <div class="box-wrap">
                                <div>
                                    <img src="/images/rail.svg" alt="logistics" />
                                    <h3>Rail</h3>
                                </div>
                            </div>
                        </div>
                        <div class="col-6  col-sm-2">
                            <div class="box-wrap">
                                <div>
                                    <img src="/images/Road.svg" alt="road" />
                                    <h3>Logistics</h3>
                                </div>
                            </div>
                        </div>
                        <div class="col-6  col-sm-2">
                            <div class="box-wrap">
                                <div>
                                    <img src="/images/Brokerage.svg" alt="brokerage" />
                                    <h3>Brokerage</h3>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- comparison side by side -->
            <section class="section-comparison-two-sides home_comparison_sec">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12 section-comparison-two-sides--container">
                            <div class="comparison-col comparison-col-left">
                                <p class="comparison-col--subheader">The Past</p>
                                <h2 class="section-title comparison-col--header">General CRM Solutions</h2>
                                <ul class="comparison-col-ul">
                                    <li>
                                        <div class="comparison-col-ul--cross">
                                            <img src="images/cross-icon.svg" alt="">
                                        </div>
                                        Expensive 
                                    </li>
                                    <li>
                                        <div class="comparison-col-ul--cross">
                                            <img src="images/cross-icon.svg" alt="">
                                        </div>
                                        Requires extensive customization to work well 
                                    </li>
                                    <li>
                                        <div class="comparison-col-ul--cross">
                                            <img src="images/cross-icon.svg" alt="">
                                        </div>
                                        Not user-friendly, steep learning curve 
                                    </li>
                                    <li>
                                        <div class="comparison-col-ul--cross">
                                            <img src="images/cross-icon.svg" alt="">
                                        </div>
                                        "Horizontal" sales-focused, not designed for freight sales 
                                    </li>
                                </ul>
                            </div>
                            <div class="comparison-col comparison-col-right">
                                <p class="comparison-col--subheader">the future</p>
                                <h2 class="section-title comparison-col--header">First Freight CRM</h2>
                                <ul class="comparison-col-ul">
                                    <li>
                                        <div class="comparison-col-ul--tick">
                                            <img src="images/success-tick-green-icon.svg" alt="">
                                        </div>
                                        Cost-effective  
                                    </li>
                                    <li>
                                        <div class="comparison-col-ul--tick">
                                            <img src="images/success-tick-green-icon.svg" alt="">
                                        </div>
                                        Intuitive and user-friendly experience 
                                    </li>
                                    <li>
                                        <div class="comparison-col-ul--tick">
                                            <img src="images/success-tick-green-icon.svg" alt="">
                                        </div>
                                        "Vertical" sales-focused, designed for the freight industry 
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- comparison how -->
            <section class="section-comparison-how">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 text-center">
                            <h3>How Do They Compare?</h3>
                        </div>
                    </div>
                    <div class="row compare-how-list">
                        <div class="compare-how-item">
                            <div class="compare-item-img">
                                <img src="/images/compare-logos/salesforce_icon.svg"  alt=""/>
                            </div>
                            <div class="compare-item-button">
                                <button class="btn-primary large" onclick="window.open('/firstfreight-vs-salesforce','_blank')"
                                    type="button">
                                    Salesforce vs First Freight  
                                </button>
                            </div>
                        </div>

                        <div class="compare-how-item">
                            <div class="compare-item-img" >
                                <img src="/images/compare-logos/microsoft-dynamics_icon.svg"  alt=""/>
                            </div>
                            <div class="compare-item-button">
                                <button class="btn-primary large"
                                    onclick="window.open('/firstfreight-vs-microsoft-dynamics','_blank')" type="button">
                                    Microsoft Dynamics vs First Freight 
                                </button>
                            </div>
                        </div>

                        <div class="compare-how-item">
                            <div class="compare-item-img">
                                <img src="/images/compare-logos/excel_icon.svg"  alt=""/>
                            </div>
                            <div class="compare-item-button">
                                <button class="btn-primary large" onclick="window.open('/firstfreight-vs-excel','_blank')"
                                    type="button">
                                    Excel/Spreadsheets vs First Freight
                               
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- testimonial 01 -->
        </div>

        <section id="testimonial" class="section-testimonial">
            <div class="container testimonial-item">
                <div class="row">
                    <div class="col-lg-4 testi-img-container">
                        <div class="testi-img-container-inner">
                            <img class="testi-img-author" src="/images/hs2.png"  alt=""/>
                        </div>
                    </div>
                    <div class="col-lg-8 testi-text-outer-wrapper">
                        <div class="testi-text-outer">
                            <div class="testi-text-left">
                                <div class="testi-quotes">
                                    <img src="/images/single-quotes.svg" alt="">
                                </div>
                            </div>
                            <div class="testi-text-right">
                                <div class="testi-text">
                                    Like other forwarders, we had used Salesforce. Our reps hated how time-consuming
                                    it was and our senior execs got tired of paying the high licensing and customization fees to
                                    resellers. Happy now with First Freight!
                               
                                </div>
                                <div class="testi-author">Stanley N.</div>
                                <div class="testi-jobtitle">Global Sales Leader </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- how it works -->
        <section id="how-it-works" class="section-how-it-works">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <div class="section-label">Freight-Specific Design </div>
                        <h2 class="section-title">How it Works</h2>
                    </div>
                </div>
                <div class="row how-it-works-list">
                    <div class="col-xl-4 col-lg-6 col-md-12">
                        <div class="item">
                            <div class="item-img">
                                <img src="/images/how-1.png"  alt=""/>
                                <div class="item-img-count">
                                    <span>1</span>
                                </div>
                            </div>
                            <p class="item-description">Manage locations and users</p>
                        </div>
                    </div>
                    <div class="col-xl-4 col-lg-6 col-md-12">
                        <div class="item">
                            <div class="item-img">
                                <img src="/images/how-2.png"  alt=""/>
                                <div class="item-img-count">
                                    <span>2</span>
                                </div>
                            </div>
                            <p class="item-description">View and track progress on sales activities and performance</p>
                        </div>
                    </div>
                    <div class="col-xl-4 col-lg-6 col-md-12">
                        <div class="item">
                            <div class="item-img">
                                <img src="/images/how-3.png"  alt=""/>
                                <div class="item-img-count">
                                    <span>3</span>
                                </div>
                            </div>
                            <p class="item-description">
                                Celebrate wins and identify improvements with built-in freight sales reports
                           
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- testimonial 02 -->
        <section class="section-testimonial reverse">
            <div class="container testimonial-item">
                <div class="row">
                    <div class="col-lg-8 testi-text-outer-wrapper">
                        <div class="testi-text-outer">
                            <div class="testi-text-left">
                                <div class="testi-quotes">
                                    <img src="/images/single-quotes.svg" alt="">
                                </div>
                            </div>
                            <div class="testi-text-right">
                                <div class="testi-text">
                                    This program is simple to use and understand. Our sales team are remote in 8
                  countries now. I can run activities reports at any time and the Deals reports have filters for Air,
                  Sea, Land and Logistics by sales stage... excellent program!
                               
                                </div>
                                <div class="testi-author">Vincent M.</div>
                                <div class="testi-jobtitle">RVP Sales, SE Asia </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 testi-img-container">
                        <div class="testi-img-container-inner">
                            <img class="testi-img-author" src="/images/hs3.png"  alt=""/>
                        </div>
                    </div>
                    <div class="col-lg-12  ">
                        <div class="startTrialContainer full-width-column">
                            <button class="btn-primary large" onclick="window.open('/FreeTrialSignup.aspx','_blank')" type="button">
                                Start Your Free Trial 
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- customer relations -->
        <section id="customer-relations" class="customer-relations">
            <div class="blue-bg">
                <img src="/images/trial-update-bg.svg" class="customer-relations-bg" alt="customer-relations-bg" />
                <section class="section">
                    <div class="container">
                        <div class="row justify-content-between">
                            <div class="col-lg-5 col-md-6 text-left align-self-center wow zoomIn">
                                <div class="section-label">Customer Relationship Management Tool </div>
                                <h2 class="section-title">CRM for Freight Sales has it all in One Place </h2>
                                <p class="section-summary">
                                    Manage your companies, contacts, deals, and activities. Capture services,
                  origins, and destinations (lanes), estimated volumes, revenue, and profit. All without switching
                  between software.
                               
                                </p>
                            </div>
                            <div class="col-lg-7 col-md-6 feature-blocks wow fadeInRight">
                                <div class="feature-blocks-left">
                                    <div class="feature-box">
                                        <div class="box-icon">
                                            <img src="/images/relationship-management/sales-stages.svg" alt="sales stages" />
                                        </div>
                                        <div class="box-info">
                                            <h3 class="box-title">Easily Track Deals Through Sales Stages</h3>
                                            <div class="box-text">
                                                <ul class="feature-blocks-ul">
                                                    <li>
                                                        <img src="/images/blue-tick.svg"  alt=""/>
                                                        <span>Drag and drop deals on different stages</span>
                                                    </li>
                                                    <li>
                                                        <img src="/images/blue-tick.svg"  alt=""/>
                                                        <span>Click on any deal to view lanes and details</span>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="feature-blocks-right">
                                    <div class="feature-box">
                                        <div class="box-icon">
                                            <img src="/images/relationship-management/forecasting.svg" alt="forecasting" />
                                        </div>
                                        <div class="box-info">
                                            <h3 class="box-title">Add Lanes for Better Forecasting</h3>
                                            <div class="box-text">
                                                <ul class="feature-blocks-ul">
                                                    <li>
                                                        <img src="/images/blue-tick.svg"  alt=""/>
                                                        <span>Capture complete lane details, including modes, origins and destinations, volumes, 
                              revenue, and profit </span>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="feature-box">
                                        <div class="box-icon">
                                            <img src="/images/relationship-management/reporting.svg" alt="reporting" />
                                        </div>
                                        <div class="box-info">
                                            <h3 class="box-title">Get Detailed Analysis with Reporting Tools </h3>
                                            <div class="box-text">
                                                <ul class="feature-blocks-ul">
                                                    <li>
                                                        <img src="/images/blue-tick.svg"  alt=""/>
                                                        <span>Freight sales reporting provides a snapshot of all sales activity and performance at a 
                              glance. </span>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </section>
        <!-- sales in the cloud -->
        <section class="sales-cloud">
            <img src="/images/hero-bg-2.svg" class="sales-cloud-bg" alt="sales-cloud-bg" />
            <section id="cloud" class="section">
                <div class="container">
                    <div class="row">
                        <div class="col-md-6 wow fadeInRight text-left">
                            <img src="/images/line-item-illustration.png" class="img-responsive contain img-contain"
                                alt="cloud-image" />
                        </div>
                        <div class="col-md-6 text-left align-self-center wow zoomIn">
                            <div class="section-label">Sales in the Cloud</div>
                            <h2 class="section-title">Manage Deals from Anywhere </h2>
                            <p class="section-summary">
                                Anytime, anywhere access, from any device. Data is securely stored in Tier One
                data centers in all regions, including Mainland China (Azure CN)
                           
                            </p>
                        </div>
                    </div>
                </div>
            </section>
        </section>
        <!-- intergrated -->
        <div id="intergrated" class="intergrated blue-bg">
            <div class="intergrated-wrapper">
                <div class="container">
                    <div class="row justify-content-between">
                        <div class="col-lg-6 col-md-6 text-left align-self-center wow zoomIn intergrated_content">
                            <div class="section-label">integrated </div>
                            <h2 class="section-title">Integrate with Your Logistics Tech Stack </h2>
                            <p class="section-summary">
                                First Freight integrates with freight quoting software, and transportation
                management systems for a seamless experience.
                           
                            </p>
                        </div>
                        <div class="col-md-6 wow fadeInRight text-left">
                            <img src="/images/logistics-tech-stack.svg" class="img-responsive contain img-contain"
                                alt="cloud-image" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- change display language -->
        <section class="language">
            <img src="/images/hero-bg-2.svg" class="language-bg" alt="language-bg" />
            <section id="language" class="section">
                <div class="container">
                    <div class="row">
                        <div class="col-md-6 left_colm  wow fadeInRight text-left">
                            <img src="/images/change-display-language.png" class="img-responsive contain img-contain"
                                alt="cloud-image" />
                        </div>
                        <div class="col-md-6 right_colm text-left align-self-center wow zoomIn">
                            <div class="section-label">Change Display Language</div>
                            <h2 class="section-title">Available in All Major Languages and Currencies </h2>
                            <p class="section-summary">
                                Easily change the display language and currency for the entire CRM, or
                customize per user.
                           
                            </p>
                        </div>
                    </div>
                </div>
            </section>
        </section>
        <!-- Pricing Section -->
        <section id="pricing" class="pricing section">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <div class="section-label">Pricing</div>
                        <h2 class="section-title">Simple and Transparent Pricing </h2>
                        <p class="section-summary">Add users without worrying about limits or hard-to-follow contracts. </p>
                        <div class="price-btns">
                            <a class="button-secondary active"
                                data-url="window.open('/FreeTrialSignup.aspx?option=annually','_blank')" data-cycle="billed annually"
                                data-cost="$60">Annual</a>
                            <a class="button-secondary" data-url="window.open('/FreeTrialSignup.aspx?option=monthly','_blank')"
                                data-cycle="billed monthly" data-cost="$75">Monthly</a>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12 section-pricing-two-sides--container">
                        <div class="section-pricing-two-sides--container-inner">
                            <div class="plan-head">
                                <div class="plan-head-inner">
                                    <div class="plan-cost">$60</div>
                                    <div class="plan-text">per user/month </div>
                                    <div class="plan-cycle">billed annually </div>
                                </div>
                            </div>
                            <div class="section-pricing-two-sides--container-inner-side-by-side">
                                <div class="pricing-col pricing-col-left">
                                    <ul class="pricing-col-ul">
                                        <li>
                                            <div class="pricing-col-ul--tick">
                                                <img src="images/success-tick-blue-icon.svg" alt="">
                                            </div>
                                            <span>Unlimited companies </span>
                                        </li>
                                        <li>
                                            <div class="pricing-col-ul--tick">
                                                <img src="images/success-tick-blue-icon.svg" alt="">
                                            </div>
                                            <span>Contacts Deals with lanes, origins</span>
                                        </li>
                                        <li>
                                            <div class="pricing-col-ul--tick">
                                                <img src="images/success-tick-blue-icon.svg" alt="">
                                            </div>
                                            <span>Destinations Sale team assignment</span>
                                        </li>
                                        <li>
                                            <div class="pricing-col-ul--tick">
                                                <img src="images/success-tick-blue-icon.svg" alt="">
                                            </div>
                                            <span>O365 calendarsPhone</span>
                                        </li>
                                    </ul>
                                </div>
                                <div class="pricing-col pricing-col-right">
                                    <ul class="pricing-col-ul">
                                        <li>
                                            <div class="pricing-col-ul--tick">
                                                <img src="images/success-tick-blue-icon.svg" alt="">
                                            </div>
                                            <span>Management sales performance analytics built-inIntegration with Gmail </span>
                                        </li>
                                        <li>
                                            <div class="pricing-col-ul--tick">
                                                <img src="images/success-tick-blue-icon.svg" alt="">
                                            </div>
                                            <span>Email and in-app supportLive web demos</span>
                                        </li>
                                        <li>
                                            <div class="pricing-col-ul--tick">
                                                <img src="images/success-tick-blue-icon.svg" alt="">
                                            </div>
                                            <span>Training</span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <div class="startTrialContainer">
                                <button class="btn-primary large" onclick="window.open('/FreeTrialSignup.aspx','_blank')" type="button">
                                    Start your Free Trial
                               
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- testimonial 03 -->
        <section class="section-testimonial">
            <div class="container testimonial-item">
                <div class="row">
                    <div class="col-lg-4 testi-img-container">
                        <div class="testi-img-container-inner">
                            <img class="testi-img-author" src="/images/hs1.png"  alt=""/>
                        </div>
                    </div>
                    <div class="col-lg-8 testi-text-outer-wrapper">
                        <div class="testi-text-outer">
                            <div class="testi-text-left">
                                <div class="testi-quotes">
                                    <img src="/images/single-quotes.svg" alt="">
                                </div>
                            </div>
                            <div class="testi-text-right">
                                <div class="testi-text">
                                    We were happy to find First Freight CRM, which is exactly what I was thinking
                  this industry needed years ago, a simple CRM for global freight sales teams - excellent idea!
                               
                                </div>
                                <div class="testi-author">Maria S.</div>
                                <div class="testi-jobtitle">National Sales Coordinator </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Free Trial Section -->
        <div id="freeTrial" class="freeTrial blue-bg">
            <div class="freeTrialWrapper">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 text-center wow zoomIn">
                            <div class="section-label">Free Trial</div>
                            <h2 class="section-title">Think Vertical! Try the CRM Designed for the
                               
                                <br />
                                Global Freight Industry Today </h2>
                            <p class="section-summary">No credit card required. </p>
                            <div class="freeTrialWrapper_form">
                                <form>
                                    <div class="freeTrialWrapper_form_wrapper">
                                        <div class="freeTrialWrapper_form_field">
                                            <input type="email" placeholder="Work email">
                                            <button type="submit">Start your Free 30-Day Trial</button>
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Footer -->
        <uc1:footer runat="server" />

    </div>

    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.matchHeight-min.js"></script>
    <script src="js/wow.min.js"></script>
    <script src="js/main-18-jul-2023.js"></script>
</body>
</html>
