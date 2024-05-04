<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FreeTrialSignup.aspx.cs" Inherits="FirstFreight.FreeTrialSignup" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>First Freight CRM | Free Trial</title>
    <link href="/css/bootstrap-20-jul-2023.min.css" rel="stylesheet" />
    <link href="/css/freetrialsignup-20-jul-2023.css" rel="stylesheet" />
    <link
        href="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAMAAABg3Am1AAABXFBMVEUAAAApmtVDvuw9t+kNdbxFwvENdbxFw/FFw/FFwvFFwvAjkc8pmtUNdrwhj84Ndbwpm9ZFw/Epm9YNdrwpmtYNdrwpm9YNdbtFw/ENdbwpmtYqm9YpmtUNdbxFw/FFw/FBve0omNREwfBFwvANdbtFw/Epm9YNdbtFw/FFwvANdbsNdbxFw/ENdbspmtYNdbxFwvBFwvAOdrwpm9YpmtYRe8ApmtVCve0NdbxGw/ENdbwpmtVFw/Eqm9YpmtVFwvAqm9YOdrxFwvBFwvApmtYNdbsNdbxFwvAqm9YomtUNdbsqm9YomdUNdbtFw/ENdbwOdrwNdbsomdUNdbwOdrwpmtUqm9ZGw/FGw/Eqm9Yqm9ZGw/FFwvANdbspmtUqm9ZGw/FFwvApmtUNdbsqm9YXgcRFwvBGw/EpmtUOdrwqm9YpmtUqm9ZGxPEOdrxGw/Epm9YNdbsOdrxFwvDKG5DKAAAAb3RSTlMA/gMIrTn38b5FLhwVCwf9+/f08O/q5tjUybOZVUM/IhkQDefh3dK4taunjnRwaWhkWk5LPjUnFRL758fDwbu6trKvn5+SioaFhYNjXV1PRz86LS0l29jMyb6mop2bmIeDgX18em9sZ2JgNzIxGhhLD0F9AAACOklEQVRIx63TZ1daQRAG4Hf3UgUBpRilCPYeFRCsUWNvsaT33pNt//+czMbPC/ee4/N5dmenLO5K6uovgjl500Yg9/U+AvmUVpcIoDekVQgBPMprvQb/2jNKqTUsBChZaR3iL99xnw+KaKV02duTJfhxM0YJ1CRqm3I9ge4SA5oqyN5ghUnZ8NHRQaXJObDHGDv10AUP2fv1QQoNipelxTg6O0grstNGLcckY9fDpvOJ84jt6OBjeC+oAjZU+2NGh+HWHFN0YKyJVFGS/hIujHjVsWCSLQOfM5JKKHqYEuaeO8WssgmWgbN+SSYSqESFGQ/D4UpZ8xyNHN0vc7/BY4Iy9MBhwBY804tEQRJWBw5XjREbvMPKqQFq0LptkFwAlqKUoG/OmYDuj/wA3krrGAiPU7x45hp2Oavpm/Vigdn3FDmGnxshRLQCh5OI1vlL/Cr8n1gSIzFjfYNLSOl0CHzIbsTENWgCgir+wOEyqXRkGd9pAixXAl4bQS96OAKnHa3ySG5TAZkiMNcnSKwKt9m0mkTdJniaQmXUNsiOzG05q/ZxxBjL1FGN2fjRODoaVLMjW9SiIfD3Nr5vEZ2V1UzrCWVYQThqqEGH6GY+Xy0wtgVv107sAUc3fP7LhGSnCNv7oy340NyW9KJpO4EL+ME/ykzSs/G7Hnz5WZDJit3pMHw6YomvtyvhU23zbE6Y1SX4ljxedOyES6qHZtBCEONi2kMQSybgAS+2UUUgPVNxBBOOcwTCPdyRf41qkynKpnkFAAAAAElFTkSuQmCC"
        rel="icon"
        type="image/x-icon" />  
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
</head> 
<body class="freeTrial-pg">
    <div class="main-container">
        <div class="container-fluid">
            <div class="page-content">
                <div class="content-inner">
                    <form id="frmFreeTrial" runat="server">
                        <div id="free-trial-form">
                            <div class="form-logo">
                                <img style="width: 260px" src="images/FirstFreight.svg" alt="logo" />
                            </div>
                            <div id="divStepOne" runat="server"> 
                                <h1 class="form-title">Start Your Free Trial
                                </h1>
                                <h2 class="form-subtitle">Let's get started. 
                                </h2>
                                <div class="form-horizontal">
                                    <div class="form-group filled">
                                        <label
                                            class="inputLabel language-entry"> 
                                            Email  
                                        </label>
                                        <asp:TextBox
                                            ID="txtEmailAddress"
                                            TextMode="Email"
                                            CssClass="form-control"
                                            runat="server"
                                            MaxLength="100"
                                            required="true"
                                            aria-autocomplete="email"
                                            oninvalid="this.setCustomValidity('Enter your Email')" 
                                            oninput="this.setCustomValidity('')">
                                        </asp:TextBox>
                                    </div>
                                    <div class="form-group filled">
                                        <label class="inputLabel language-entry">Name </label>
                                        <asp:TextBox
                                            ID="txtFullName"
                                            CssClass="form-control"
                                            runat="server"
                                            MaxLength="100"
                                            aria-autocomplete="name" 
                                            required="true"> 
                                        </asp:TextBox>
                                    </div>
                                    <div class="form-group filled">
                                        <label
                                            class="inputLabel language-entry">
                                            Company</label>
                                        <asp:TextBox
                                            ID="txtCompany"
                                            CssClass="form-control"
                                            runat="server"
                                            MaxLength="100" 
                                            required="true"> 
                                        </asp:TextBox>
                                    </div>
                                    <div class="form-group filled">
                                        <label
                                            class="inputLabel language-entry">
                                            Country</label>
                                        <asp:DropDownList
                                            ID="ddlCountry"
                                            CssClass="form-control"
                                            runat="server"
                                            MaxLength="100"
                                            required="true">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-group filled">
                                        <label
                                            class="inputLabel language-entry"> 
                                            Password  
                                        </label>
                                        <asp:TextBox
                                            ID="txtPassword"
                                            CssClass="form-control"
                                            runat="server"
                                            TextMode="Password"
                                            aria-autocomplete="new-password"
                                            MaxLength="50" 
                                            required="true">
                                        </asp:TextBox> 
                                    </div>
                                    <div class="form-group btn-row">
                                        <a class="btn btn-lg btn-primary" id="btnFreeTrialBegin">Get Started</a>
                                    </div>
                                </div>
                                <span
                                    id="spanSignin"
                                    runat="server" 
                                    visible="True">Already a member?  
                                    <a href="https://crm.firstfreight.com/">Sign In</a>
                                </span>
                            </div>


                        </div>

                    </form>
                </div>

            </div>
        </div>
        <!-- .row -->
    </div>
    <!-- .footer Section -->
    <div class="footer">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-4 col-sm-5">
                    <a target="_blank" href="Terms.aspx">Terms & Conditions</a><span class="divider"></span>
                    <a target="_blank" href="Privacy.aspx">Privacy Policy</a>
                </div>
                <div class="col-md-8 col-sm-7 text-right">
                    <div>First Freight &#169; 2023</div>
                </div>
            </div>
        </div>
    </div>

    <div id="loadingModal" class="modal modal-wide fade">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-body">
                    <div class="spinner"></div>
                    <p id="loading-text"> 
                        Please wait while we are setting up your
                        account. This might take 1-2 minutes. This You
                        will shortly be redirected to the CRM... 
                    </p>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->

    </div>
    <!-- /.modal -->
    <script src="/js/jquery-3.4.1.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>
    <script src="/js/freetrialsignup-25-mar-2021.js"></script>
 
    <script>
        var APP_ID = 'y3oan1ik';
        window.intercomSettings = {
            app_id: APP_ID,
        };
        (function () {
            var w = window;
            var ic = w.Intercom;
            if (typeof ic === 'function') {
                ic('reattach_activator');
                ic('update', w.intercomSettings);
            } else {
                var d = document;
                var i = function () {
                    i.c(arguments);
                };
                i.q = [];
                i.c = function (args) {
                    i.q.push(args);
                };
                w.Intercom = i;
                var l = function () {
                    var s = d.createElement('script');
                    s.type = 'text/javascript';
                    s.async = true;
                    s.src = 'https://widget.intercom.io/widget/' + APP_ID;
                    var x = d.getElementsByTagName('script')[0];
                    x.parentNode.insertBefore(s, x);
                };
                if (document.readyState === 'complete') {
                    l();
                } else if (w.attachEvent) {
                    w.attachEvent('onload', l);
                } else {
                    w.addEventListener('load', l, false);
                }
            }
        })();

        window.Intercom('boot', {
            app_id: APP_ID,
        });
 
    </script>
</body>

</html>
