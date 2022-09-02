//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using GoogleMobileAds.Api;
//using System;

//public class Admob : MonoBehaviour
//{
//    //external references


//    private RewardedAd rewardedAd;

//    private InterstitialAd interstitial;

//    private BannerView bannerView;



//    public void RequestRewardedAd()
//    {
//#if UNITY_ANDROID
//        string adUnitId = "ca-app-pub-3940256099942544/5224354917"; //test 
//#elif UNITY_IPHONE
//            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
//#else
//            string adUnitId = "unexpected_platform";
//#endif

//        rewardedAd = new RewardedAd(adUnitId);

//        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
//        rewardedAd.OnAdClosed += HandleRewardedAdClosed;

//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();
//        // Load the rewarded ad with the request.
//        rewardedAd.LoadAd(request);
//    }

//    private void RequestInterstitial()
//    {
//#if UNITY_ANDROID
//        string adUnitId = "ca-app-pub-3940256099942544/1033173712"; //test
//#elif UNITY_IPHONE
//        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
//#else
//        string adUnitId = "unexpected_platform";
//#endif

//        // Initialize an InterstitialAd.
//        interstitial = new InterstitialAd(adUnitId);
//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();
//        // Load the interstitial with the request.
//        interstitial.LoadAd(request);
//    }

//    private void RequestBanner()
//    {
//#if UNITY_ANDROID
//        string adUnitId = "ca-app-pub-3940256099942544/6300978111"; //test
//#elif UNITY_IPHONE
//            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
//#else
//            string adUnitId = "unexpected_platform";
//#endif

//        // Create a 320x50 banner at the top of the screen.
//        bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();

//        // Load the banner with the request.
//        bannerView.LoadAd(request);
//    }

//    // Start is called before the first frame update
//    void Start()
//    {
//#if UNITY_ANDROID
//        string appId = "................"; //your admob app id 
//#elif UNITY_IPHONE
//            string appId = "ca-app-pub-3940256099942544~1458002511";
//#else
//            string appId = "unexpected_platform";
//#endif

//        // Initialize the Google Mobile Ads SDK.
//        MobileAds.Initialize(appId);

//        RequestRewardedAd();
//        RequestInterstitial();
//        RequestBanner();
//        ShowBanner();
        
//    }

//    //show banner
//    public void ShowBanner()
//    {
//        bannerView.Show();
//    }


//    //show rewarded ad
//    public void ShowRewardedAd()
//    {
//        if (rewardedAd.IsLoaded())
//        {
//            rewardedAd.Show();
//        }
//    }

//    //show intersitial
//    public void ShowIntersitial()
//    {
//        if (interstitial.IsLoaded())
//        {
//            interstitial.Show();
//        }
//    }

   


//    //Reward Video Ad Handlers

//    public void HandleUserEarnedReward(object sender, Reward args)
//    {
//        //code to give user the reward

//    }

//    public void HandleRewardedAdClosed(object sender, EventArgs args)
//    {
//        RequestRewardedAd();//we have to create a new object for the rewarded ad if we want to see the ad again
//    }

//    //Documentation for admob ads https://developers.google.com/admob/unity/start

//}//class
