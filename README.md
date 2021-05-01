# ExpressBusServices_TLM

Optional sister mod of Express Bus Service (https://github.com/Vectorial1024/ExpressBusServices) for better compatibility with TLM: if also using TLM, then TLM's termini settings are read to let Express Bus Services determine whether to allow for insta-depart at bus stops.

Note that at time of writing (1 May 2021) the way TLM skips stops is actually 1 step ahead of us. They predict whether it is possible to skip stops, and update the vehicle destination before the vehicle actually arrived at the bus stop, so this mod is actually "disabled" for most of the time. However, there is still a possibility that TLM predicted wrongly and decides to stop at a bus stop, and then this mod becomes effective to "pick it up" and usher the affected bus to insta-depart.
