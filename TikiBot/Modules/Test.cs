using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace TikiBot.Modules {
    public class Test : ModuleBase<SocketCommandContext> {
        private Random r;
        public Test() { r = new Random(); }

        [Command("test")]
        public async Task test() {
            await Context.Channel.SendMessageAsync("success!");
        }

        [Command("noni")]
        public async Task noni() {
            await Context.Channel.SendMessageAsync("http://kaspernooteboom.nl/tikibot/noni_" + r.Next(0, 2) + ".png");
        }

        [Command("ginger")]
        public async Task ginger() {
            await Context.Channel.SendMessageAsync("http://kaspernooteboom.nl/tikibot/ginger.png");
        }
    }
}