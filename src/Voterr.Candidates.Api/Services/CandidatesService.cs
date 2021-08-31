using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Voterr.Candidates.Api.Models;

namespace Voterr.Candidates.Api.Services
{
    public class CandidatesService
    {
        private readonly ConcurrentBag<Candidate> _candidates;

        public CandidatesService()
        {
            _candidates = new ConcurrentBag<Candidate>()
            {
                new (){Id = 1, Name = "Windows", Description = "Microsoft Windows (also referred to as Windows or Win) is a graphical operating system developed and published by Microsoft. It provides a way to store files, run software, play games, watch videos, and connect to the Internet."},
                new (){Id = 2, Name = "Mac OS X", Description = "MacOS is a proprietary graphical operating system developed and marketed by Apple Inc. since 2001. It is the primary operating system for Apple's Mac computers. Within the market of desktop, laptop and home computers, and by web usage, it is the second most widely used desktop OS, after Windows NT."},
                new (){Id = 3, Name = "Linux", Description = "Linux is a family of open-source Unix-like operating systems based on the Linux kernel, an operating system kernel first released on September 17, 1991, by Linus Torvalds. Linux is typically packaged in a Linux distribution."}
            };
        }

        public List<Candidate> GetCandidates() => _candidates.ToList();
    }
}