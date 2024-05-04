<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstFreightVsMicrosoftDynamics.aspx.cs" Inherits="FirstFreight.FirstFreightVsMicrosoftDynamics" %>

<%@ Register Src="~/_usercontrols/nav.ascx" TagPrefix="uc1" TagName="nav" %>
<%@ Register Src="~/_usercontrols/footer.ascx" TagPrefix="uc1" TagName="footer" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>First Freight vs Microsoft Dynamics | CRM for Logistics Sales</title>
    <meta
        name="description"
        content="Looking for a Freight Forwarding-Friendly Alternative to Microsoft Dynamics?" />
    <link href="css/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="css/animate.min.css" rel="stylesheet" />
    <link href="css/style-18-jul-2023.css" rel="stylesheet" />
    <!--Start Sentry-->
    <script src="https://js.sentry-cdn.com/59d8d19b8d5a4e188e7c51a3b26a78d4.min.js" crossorigin="anonymous"></script>
    <!--End Sentry-->
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
    <!--Start Speed-curve-->
    <script>LUX = function () { function n() { return Date.now ? Date.now() : +new Date } var r, e = n(), t = window.performance || {}, a = t.timing || { navigationStart: (null === (r = window.LUX) || void 0 === r ? void 0 : r.ns) || e }; function o() { return t.now ? t.now() : n() - a.navigationStart } LUX = { ac: [], addData: function (n, r) { return LUX.cmd(["addData", n, r]) }, cmd: function (n) { return LUX.ac.push(n) }, init: function () { return LUX.cmd(["init"]) }, mark: function () { for (var n = [], r = 0; r < arguments.length; r++)n[r] = arguments[r]; if (t.mark) return t.mark.apply(t, n); var e = n[0], a = n[1] || {}; void 0 === a.startTime && (a.startTime = o()); LUX.cmd(["mark", e, a]) }, markLoadTime: function () { return LUX.cmd(["markLoadTime", o()]) }, measure: function () { for (var n = [], r = 0; r < arguments.length; r++)n[r] = arguments[r]; if (t.measure) return t.measure.apply(t, n); var e, a = n[0], i = n[1], u = n[2]; e = "object" == typeof i ? n[1] : { start: i, end: u }; e.duration || e.end || (e.end = o()); LUX.cmd(["measure", a, e]) }, send: function () { return LUX.cmd(["send"]) }, ns: e }; var i = LUX; if (window.LUX_ae = [], window.addEventListener("error", (function (n) { window.LUX_ae.push(n) })), window.LUX_al = [], "function" == typeof PerformanceObserver && "function" == typeof PerformanceLongTaskTiming) { var u = new PerformanceObserver((function (n) { for (var r = n.getEntries(), e = 0; e < r.length; e++)window.LUX_al.push(r[e]) })); try { u.observe({ type: "longtask" }) } catch (n) { } } return i }();</script>
    <script src="https://cdn.speedcurve.com/js/lux.js?id=4405189326" defer crossorigin="anonymous"></script>
    <!--End Speed-curve-->
    <!--Start LogRocket-->
    <script src="https://cdn.lr-intake.com/LogRocket.min.js" crossorigin="anonymous"></script>
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
<body id="page-top" class="comparison_pg dynamics_pg">
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
        <!-- comparison -->
        <section class="section-comparison crm-design light-white-bg">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <div class="section-label">
                            CRM Comparison                       
                        </div>
                        <h1 class="section-title">Looking for a Freight<br>
                            Forwarding-Friendly Alternative<br>
                            to Microsoft Dynamics?</h1>
                    </div>
                    <div class="col-lg-12  ">
                        <div class="startTrialContainer full-width-column">
                            <button class="btn-primary large" onclick="window.open('/FreeTrialSignup.aspx','_blank')" type="button">
                                Start Your Free Trial
                           
                            </button>
                            <span>(No Credit Card Required)</span>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- trusted by freight sales teams -->
        <section class="section-trusted-freight-teams">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <h3>These Customers Love Using our CRM</h3>
                    </div>
                </div>

                <div class="row client-list">
                    <div class="col-lg-4 col-md-12">
                        <div class="client-list-item">
                            <div class="client-list-img">
                                <img src="/images/customer-logos/kwe.png" />
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12">
                        <div class="client-list-item">
                            <div class="client-list-img">
                                <img src="/images/customer-logos/ktl.png" />
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-12">
                        <div class="client-list-item">
                            <div class="client-list-img">
                                <img src="/images/customer-logos/pil.png" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- comparison side by side -->
        <section class="section-comparison-two-sides">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 section-comparison-two-sides--container">

                        <div class="comparison-col comparison-col-left">
                            <div class="provider-logo text-center">
                                <img class="firstfreight" src="/images/FirstFreight.svg">
                            </div>
                            <h2 class="comparison-col--header">First Freight CRM was developed for freight forwarders and logistics providers, by developers with extensive industry knowledge.</h2>
                            <p class="comparison-col--sub-header">It's main features include:</p>
                            <ul class="comparison-col-ul">
                                <li>
                                    <img src="images/blue-tick.svg" />
                                    <span>An intuitive, easy-to-navigate interface</span>
                                </li>
                                <li>
                                    <img src="images/blue-tick.svg" />
                                    <span>Specific dashboards and tabs for managing companies, contacts, and deals with mode, origins and destinations, estimated volumes, and revenue and profit</span>
                                </li>
                                <li>
                                    <img src="images/blue-tick.svg" />
                                    <span>Supports how you sell, including sea, air, road, rail, logistics, and brokerage</span>
                                </li>
                                <li>
                                    <img src="images/blue-tick.svg" />
                                    <span>Your data is securely stored in Tier One data centers in all regions, including mainland China (Azure CN)</span>
                                </li>
                                <li>
                                    <img src="images/blue-tick.svg" />
                                    <span>Customizable for multiple different languages and currencies</span>
                                </li>
                            </ul>
                            <p class="comparison-col--description">First Freight is a simple, yet powerful CRM that supports the business needs of freight forwarding companies and global logistics without being overwhelming, or requiring extensive development or the need to navigate complex licensing.</p>
                        </div>

                        <div class="comparison-vs-icon-outer">
                            <div class="comparison-vs-icon">
                                <span>vs</span>
                            </div>
                        </div>

                        <div class="comparison-col comparison-col-right">
                            <div class="provider-logo text-center">
                                <img class="dynamics" src="/images/compare-logos/microsoft-dynamics_logo.png" />
                            </div>
                            <h2 class="comparison-col--header">Microsoft Dynamics is an enterprise CRM that consists of a variety of business-focused applications.</h2>
                            <p class="comparison-col--sub-header">It's high-level features include:</p>
                            <ul class="comparison-col-ul">
                                <li>
                                    <img src="images/blue-tick.svg" />
                                    <span>Has customer service, sales, marketing, finance, commerce, and supply chain functionality</span>
                                </li>
                                <li>
                                    <img src="images/blue-tick.svg" />
                                    <span>Brings together a variety of Microsoft tools in one place - Microsoft 365, Microsoft Cloud, Microsoft Power Platform, and more</span>
                                </li>
                                <li>
                                    <img src="images/blue-tick.svg" />
                                    <span>Is completely customizable with applications and services offered by reselling partners</span>
                                </li>
                            </ul>
                            <p class="comparison-col--description">There's no doubt that Microsoft Dynamics is a powerful platform. It's actually both a CRM and an Enterprise Resource Planning system, or ERP. The biggest hurdle with Dynamics is navigating licensing and customizations without overspending: it's almost impossible to optimize your Microsoft licensing without the help of a dedicated third-party service provider. In addition, if you don't have the resources to customize the platform yourself, you must also navigate subscriptions and licensing for applications provided by third-party resellers.</p>
                        </div>

                    </div>
                </div>
            </div>
        </section>
        <section id="table-comparison" class="section-table-comparison blue-bg microsoft_dynamics_sec">
            <div class="section-table-comparison-wrapper">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 text-center section-table-comparison--header">
                            <div class="section-label">
                                First Freight vs. Microsoft Dynamics
                           
                            </div>
                            <h2 class="section-title">See How First Freight and<br>
                                Microsoft Dynamics Stack Up</h2>
                        </div>
                        <div class="col-lg-12 text-center section-table-comparison--table">
                            <table>
                                <thead>
                                    <tr>
                                        <th></th>
                                        <th>First Freight</th>
                                        <th>Microsoft Dynamics</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Free Trial</td>
                                        <td>
                                            <img src="images/success-tick-green-icon.svg"></td>
                                        <td>
                                            <img src="images/success-tick-green-icon.svg"></td>
                                    </tr>
                                    <tr>
                                        <td>Price</td>
                                        <td>Starts at $60 per user/month</td>
                                        <td>Supply chain management platform starts at $180 per user/month, other features and MS apps are charged as per-user add-ons</td>
                                    </tr>
                                    <tr>
                                        <td>Feature-inclusive</td>
                                        <td>Yes, all features for freight and logistics are included out-of-the-box</td>
                                        <td>Licensing is difficult to navigate; high fees for customizations and subscriptions to applications are typical</td>
                                    </tr>
                                    <tr>
                                        <td>Built for the freight industry</td>
                                        <td>
                                            <img src="images/success-tick-green-icon.svg"></td>
                                        <td>
                                            <img src="images/cross-icon.svg"></td>
                                    </tr>
                                    <tr>
                                        <td>Sales focus</td>
                                        <td>Vertical</td>
                                        <td>Mainly horizontal with some supply chain features</td>
                                    </tr>
                                    <tr>
                                        <td>Integrations</td>
                                        <td>Integrates with popular TMS</td>
                                        <td>Integrates with popular TMS</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class="col-lg-12 text-center section-table-comparison--footer">
                            <h3 class="inner-label">Finally, a CRM built for freight forwarders and global logistics. Try it today.
                            </h3>
                            <div class="startTrialContainer full-width-column">
                                <button class="btn-primary large" onclick="window.open('FreeTrialSignup.aspx','_blank')" type="button">
                                    Start Your Free Trial
                           
                                </button>
                                <span class="text-white">(No Credit Card Required)</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="freight_reasons_sec">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <div class="section-label">First Freight vs. Microsoft Dynamics</div>
                        <h2 class="section-title">3 Reasons Why First Freight is Better than Microsoft Dynamics</h2>
                    </div>
                </div>
                <div class="row inner_row">
                    <div class="col-md-7">
                        <div class="reason_content_col">
                            <h3>No Complex Customizations Needed</h3>
                            <div class="inner_wrapper">
                                <div class="data_col">
                                    <img src="images/FirstFreight.svg" alt="">
                                    <p>Engineered to fit with the needs of  logistics and freight companies without the need to build or pay for software customizations</p>
                                </div>
                                <div class="data_col">
                                    <img src="images/compare-logos/microsoft-dynamics_logo.png" alt="">
                                    <p>Often need to pay third party app sellers and developers to customize the system to support the freight forwarding or logistics sales cycle</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-5">
                        <div class="reason_img_col">
                            <img src="images/No-Complex-customizations-Needed.png" alt="">
                        </div>
                    </div>
                </div>
                <div class="row inner_row">
                    <div class="col-md-5">
                        <div class="reason_img_col">
                            <img src="images/User-Friendly.png" alt="">
                        </div>
                    </div>
                    <div class="col-md-7">
                        <div class="reason_content_col">
                            <h3>User-Friendly</h3>
                            <div class="inner_wrapper">
                                <div class="data_col">
                                    <img src="images/FirstFreight.svg" alt="">
                                    <p>Straightforward navigation and easy-to-use software means you can manage your business easier and faster</p>
                                </div>
                                <div class="data_col">
                                    <img src="images/compare-logos/microsoft-dynamics_logo.png" alt="">
                                    <p>Connecting different Microsoft applications and navigating licensing and customizations is difficult</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row inner_row">
                    <div class="col-md-7">
                        <div class="reason_content_col">
                            <h3>Integrates with popular Transportation Management Software</h3>
                            <div class="inner_wrapper">
                                <div class="data_col">
                                    <img src="images/FirstFreight.svg" alt="">
                                    <p>Easily integrate with TMS like Cargowise, ensuring streamlined business operations no matter what software you're using</p>
                                </div>
                                <div class="data_col">
                                    <img src="images/compare-logos/microsoft-dynamics_logo.png" alt="">
                                    <p>May require a third-party application as a middleman to facilitate the integration, or custom development</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-5">
                        <div class="reason_img_col">
                            <img src="images/management-software.png" alt="">
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="comparison_testimonial_sec">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12 text-center">
                        <div class="section-label">First Freight vs. Microsoft Dynamics</div>
                        <h2 class="section-title">First Freight Costs Less Than Microsoft Dynamics</h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <div class="testi_left_content">
                            <h3>Get a freight-friendly CRM with an intuitive interface for as little as $60 per user per month</h3>
                            <p>The lowest-cost plan for First Freight gives you access to the entire CRM, with no features blocked by paywalls or expensive licensing fees. Plus, you can add more users as your business grows without limits.</p>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="testi_right_content">
                            <div class="testi-img-container">
                                <div class="testi-img-container-inner">
                                    <img class="testi-img-author" src="/images/hs2.png">
                                </div>
                            </div>
                            <div class="testi_inner_wrapper">
                                <div class="testi-text">Like other forwarders, we had used Salesforce. Our reps hated how time-consuming it was and our senior execs got tired of paying the high licensing and customization fees to resellers. Happy now with First Freight!</div>
                                <div class="testi-author">Stanley N.</div>
                                <div class="testi-jobtitle">Global Sales Leader</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <div id="freeTrial" class="freight_free_trial freeTrial blue-bg">
            <div class="freeTrialWrapper">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 text-center wow zoomIn">
                            <div class="section-label">Free Trial</div>
                            <h2 class="section-title">Try it For Yourself</h2>
                            <p>Easily manage global freight sales activities and improve results</p>
                            <div class="startTrialContainer full-width-column">
                                <button class="btn-primary large" onclick="window.open('FreeTrialSignup.aspx','_blank')" type="button">
                                    Start Your Free Trial
                               
                                </button>
                                <span>(No Credit Card Required)</span>
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
