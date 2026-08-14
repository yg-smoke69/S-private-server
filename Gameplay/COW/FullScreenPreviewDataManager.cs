using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DE3")]
public class FullScreenPreviewDataManager : SingletonModule<FullScreenPreviewDataManager>
{
	[Token(Token = "0x2002DE4")]
	private sealed class _003CGetFullScreenPreviewDataByID_003Ec__AnonStorey0
	{
		[Token(Token = "0x40119BE")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x60133C4")]
		[Address(RVA = "0x105072C", Offset = "0x105072C", VA = "0x105072C")]
		public _003CGetFullScreenPreviewDataByID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60133C5")]
		[Address(RVA = "0x1050734", Offset = "0x1050734", VA = "0x1050734")]
		internal bool _003C_003Em__0(FullScreenPreviewData d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40119BD")]
	[FieldOffset(Offset = "0xC")]
	private List<FullScreenPreviewData> m_DataList;

	[Token(Token = "0x60133C0")]
	[Address(RVA = "0x1050340", Offset = "0x1050340", VA = "0x1050340")]
	public FullScreenPreviewDataManager()
	{
	}

	[Token(Token = "0x60133C1")]
	[Address(RVA = "0x1050404", Offset = "0x1050404", VA = "0x1050404", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60133C2")]
	[Address(RVA = "0x1050528", Offset = "0x1050528", VA = "0x1050528", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60133C3")]
	[Address(RVA = "0x10505E8", Offset = "0x10505E8", VA = "0x10505E8")]
	public FullScreenPreviewData GetFullScreenPreviewDataByID(uint itemID)
	{
		return null;
	}
}
