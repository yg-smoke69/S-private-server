using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003178")]
public class ClientReissueData
{
	[Token(Token = "0x4012CF0")]
	[FieldOffset(Offset = "0x8")]
	public List<ClientReissueItemData> CurrentPeriodReissueData;

	[Token(Token = "0x4012CF1")]
	[FieldOffset(Offset = "0xC")]
	public List<ClientReissueItemData> FutureReviewData;

	[Token(Token = "0x6014CAD")]
	[Address(RVA = "0x172C8E8", Offset = "0x172C8E8", VA = "0x172C8E8")]
	public ClientReissueData()
	{
	}
}
