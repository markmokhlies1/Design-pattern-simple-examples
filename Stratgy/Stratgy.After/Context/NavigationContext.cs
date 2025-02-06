using Stratgy.After.Interface;
using Stratgy.After.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratgy.After.Context
{
    public class NavigationContext
    {
        private INavigationStrategy _strategy;
        public NavigationContext(INavigationStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SwitchNavigationStrategy(INavigationStrategy strategy)
        {
            _strategy = strategy;
        }
        public Route Navigate(string origin, string destination)
        {
            return _strategy.Navigate(origin, destination);
        }
    }
}
