#include "qrsdet.h"

#if defined QRSDETECTDLL_EXPORTS
#define DECLDIR __declspec(dllexport)
#else
#define DECLDIR __declspec(dllimport)
#endif


DECLDIR int QRSDetProc(int datum, int init);