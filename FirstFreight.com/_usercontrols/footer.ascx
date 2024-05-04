<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="footer.ascx.cs" %>
<!-- Footer -->
<footer class="footer">
    <div class="footer-top">
        <div class="container">
            <div class="row">
                <div class="col-md-3 col-sm-12 footerLogo">
                    <a class="footer-brand" href="Default.aspx"><img src="images/FirstFreight.svg" alt="FE_LOGO" /></a>
                </div>
                <div class="col-md-9 col-sm-12 footerMenus">
                    <div class="footerNav topNav">
                        <ul class="nav">
                            <li><a target="_blank" href="https://crm.firstfreight.com/" title="CRM Login">Sign In</a></li>
                            <li><a data-ref="#freight-crm" href="/#freight-crm">Product</a></li>
                            <li><a data-ref="#pricing" href="/#pricing">Pricing</a></li>
							<li><a data-ref="#testimonial" href="/#testimonial">Testimonials</a></li>
							<li><a data-ref="Privacy.aspx"  href="Privacy">Privacy Policy</a></li>
							<li><a data-ref="Terms.aspx"   href="Terms">Terms</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class="footer_bottom">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="copyright">First Freight CRM &copy; 2023. All Rights reserved.</div>
                </div>
                <div class="col-md-6">
                    <div class="follow_us">Follow Us:
                        <ul>
                            <li><a target="_blank" href="https://www.facebook.com/firstfreightcrm/"><img src="images/facebook_social.svg" title="" alt=""></a></li>
                            <li><a target="_blank" href="https://twitter.com/FirstFreightCRM"><img src="images/twitter_social.svg" title="" alt=""></a></li>
							<li><a target="_blank" href="https://www.linkedin.com/company/first-freight"><img src="images/linkedin_social.svg" title="" alt=""></a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id="cookiePopup" class="popup-overlay">
        <div>We use cookies to help us deliver a personalized experience. By using this website, you agree to our use of cookies. To find out more see our <a href="Privacy.aspx" class="white-link">Privacy Policy.</a></div>
        <a id="closeCookiePopup" href="#" class="close-popup">X</a>
    </div>
</footer>

<script>
    var APP_ID = "y3oan1ik";
    window.intercomSettings = {
        app_id: APP_ID,
      };
    (function(){var w=window;var ic=w.Intercom;if(typeof ic==="function"){ic('reattach_activator');ic('update',w.intercomSettings);}else{var d=document;var i=function(){i.c(arguments);};i.q=[];i.c=function(args){i.q.push(args);};w.Intercom=i;var l=function(){var s=d.createElement('script');s.type='text/javascript';s.async=true;s.src='https://widget.intercom.io/widget/' + APP_ID;var x=d.getElementsByTagName('script')[0];x.parentNode.insertBefore(s, x);};if(document.readyState==='complete'){l();}else if(w.attachEvent){w.attachEvent('onload',l);}else{w.addEventListener('load',l,false);}}})();

    window.Intercom('boot', {
           app_id: APP_ID,
    });
</script>
