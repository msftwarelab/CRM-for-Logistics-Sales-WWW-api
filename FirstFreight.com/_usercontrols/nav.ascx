<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="nav.ascx.cs" %>

<!-- Main Navigation -->
<div class="navbar-wrapper">
    <nav class="container">
        <div class="row">
            <div class="col-md-3 col site_logo">
                <a class="navbar-brand" href="Default.aspx">
                    <img src="images/FirstFreight.svg" alt="First Freight Logo" /></a>
            </div>
            <div id="main-nav" class="main-nav col-md-9 col">
                <ul class="nav">
                    <li><a data-ref="#freight-crm" href="/#freight-crm">Product</a></li>
                    <li><a data-ref="#pricing" href="/#pricing">Pricing</a></li>
                    <li><a data-ref="#testimonial" href="/#testimonial">Testimonials</a></li>
                    <li><a target="_blank" href="https://crm.firstfreight.com/" title="CRM Login">Sign In</a></li>
                    <li class="rqst_demo_li">
                        <button   class="request_demo btn-primary btn-outlines" >View Demo </button>
                    </li>
                    <li>
                        <button class="btn-primary" type="button" onclick="window.open('FreeTrialSignup.aspx','_blank')">Start Free Trial</button></li>
                </ul>
                <!-- .toggle-menu -->
                <a class="toggle-menu" href="javascript:;">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </a>
            </div>
        </div>
    </nav>

    <!-- .mobile menu -->
    <div class="mobile-menu blue-bg">
        <div class="menu-table">
            <ul class="menu">
                <li><a data-ref="#freight-crm" href="/#freight-crm">Product</a></li>
                <li><a data-ref="#pricing" href="/#pricing">Pricing</a></li>
                <li><a data-ref="#testimonial" href="/#testimonial">Testimonials</a></li>
                <li><a target="_blank" href="https://crm.firstfreight.com/" title="CRM Login">Sign In</a></li>
                <li><a target="_blank" href="https://crm.firstfreight.com/" title="CRM Login">Sign In</a></li>
                <li><button class="request_demo btn-primary btn-outlines" type="button">View Demo</button>
                  
                </li>
                <li>
                    <button class="btn-primary" type="button" onclick="window.open('FreeTrialSignup.aspx','_blank')">Start Free Trial</button></li>
            </ul>
        </div>
    </div>
</div>

<script>

    document.addEventListener("DOMContentLoaded", function () {
        const els = document.getElementsByClassName("request_demo");
        Array.prototype.forEach.call(els, function (el) {
            el.onclick = function () {
                var url = 'http://support.firstfreight.com/en/articles/4408902-free-trial-welcome-aboard';
                window.open(url, '_blank');
            }
        });
       
    }); 
   
</script>