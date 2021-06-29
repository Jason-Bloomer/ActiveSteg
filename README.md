# ActiveSteg v2.23
## An Always-On-Screen GPU-Accelerated Steganography Filter

A personal tool I developed in my spare time to reveal steganographically
hidden images and data on webpages, in videos, and nearly any other media
that can be viewed on your screen.


The filtering process is quite fast, though I believe it could be made
even faster with a screen shader that could be offloaded to the GPU.
This is something I will attempt with ActiveSteg v3.

Transparency of the window can be adjusted for viewing, and the program
supports loading preexisting image files as well as capturing from the screen.

There is also an ASCII<>HEX viewer which can read pixel data and display
its ASCII and Hexadecimal equivalent, in the case there is raw data that
can be interpereted from the image.

## TODO:

- Add cursor-tracking and click&drag selection/cropping
- Add more filters (F5, BPCS, and others)
- Correct time delayed filtering (Current implementation's a bit buggy...)
- Improve filtering speed