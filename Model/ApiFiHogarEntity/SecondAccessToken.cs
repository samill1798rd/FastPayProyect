﻿namespace Model.ApiFiHogarEntity
{
    public class SecondAccessToken
    {
        public string access_token { get; set; }
        public string scope { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public Header header { get; set; }
    }
}
