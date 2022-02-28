namespace QualitasDigitalSpecFlowCSharp.PageObjects
{
    /// <summary>
    /// A generic page object implementation
    /// </summary>
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            return page;
        }

        /// <summary>
        /// HomePage
        /// </summary>
        public static HomePage Home => GetPage<HomePage>();

        /// <summary>
        /// AboutUsPage
        /// </summary>
        public static AboutUsPage AboutUs => GetPage<AboutUsPage>();

        /// <summary>
        /// PricingAndServicesPage
        /// </summary>
        public static PricingAndServicesPage PricingAndServices => GetPage<PricingAndServicesPage>();

        /// <summary>
        /// FaqPage
        /// </summary>
        public static FaqPage Faq => GetPage<FaqPage>();

        /// <summary>
        /// NewsAndNotesPage
        /// </summary>
        public static NewsAndNotesPage NewsAndNotes => GetPage<NewsAndNotesPage>();

        /// <summary>
        /// TestimonialsPage
        /// </summary>
        public static TestimonialsPage Testimonials => GetPage<TestimonialsPage>();

        /// <summary>
        /// ScheduleConsultationPage
        /// </summary>
        public static ScheduleConsultationPage ScheduleConsultation => GetPage<ScheduleConsultationPage>();

        /// <summary>
        /// ContactUsPage
        /// </summary>
        public static ContactUsPage ContactUs => GetPage<ContactUsPage>();
    }
}
