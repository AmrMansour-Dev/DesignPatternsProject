using DesignPatternsProject.Observer.Enum;
using DesignPatternsProject.Observer.Interfaces;
using DesignPatternsProject.Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    internal class OnlineMarketPlace
    {
        private Dictionary<EventType, List<ISubscriber>> Subscribers;
        private List<Offer> OffersList;
        private List<Product> ProductsList;

        public OnlineMarketPlace()
        {
            OffersList = new List<Offer>();
            ProductsList = new List<Product>();
            Subscribers = new Dictionary<EventType, List<ISubscriber>>();
        }

        public void Subscribe(EventType eventType, ISubscriber subscriber)
        {
            if(!Subscribers.TryGetValue(eventType, out List<ISubscriber>? value))
            {
                value = new List<ISubscriber>();
                Subscribers[eventType] = value;
            }

            value.Add(subscriber);
        }
        public void AddProduct(Product product)
        {
            ProductsList.Add(product);
            NotifySubscribers(EventType.New_Product, $"A new Product : {product.Name} is available with {product.Price} L.E");
        }

        public void AddOffer(Offer offer)
        {
            OffersList.Add(offer);
            NotifySubscribers(EventType.New_Offer, $"A new offer : {offer.Message} ");
        }


        public void NotifySubscribers(EventType eventType, string message)
        {
            if(Subscribers.TryGetValue(eventType,out List<ISubscriber>? value))
            {
                foreach(var subscriber in value)
                {
                    subscriber.Notify(message);
                }
            }
        }

        public void RemoveSubscriber(EventType eventType,ISubscriber subscriber)
        {
            if (Subscribers.TryGetValue(eventType, out List<ISubscriber>? value))
            {
                value.Remove(subscriber);
            }
        }
    }
}
