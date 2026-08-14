using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200022D")]
public class SingerMiniMusicGamePhaseOneConfigManager : SingletonModule<SingerMiniMusicGamePhaseOneConfigManager>
{
	[Token(Token = "0x4000D64")]
	[FieldOffset(Offset = "0xC")]
	private List<SingerMiniMusicGamePhaseOneConfigData> dataList;

	[Token(Token = "0x17000169")]
	public List<SingerMiniMusicGamePhaseOneConfigData> DataList
	{
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x20ED46C", Offset = "0x20ED46C", VA = "0x20ED46C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x20ED3A8", Offset = "0x20ED3A8", VA = "0x20ED3A8")]
	public SingerMiniMusicGamePhaseOneConfigManager()
	{
	}

	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x20ED4C4", Offset = "0x20ED4C4", VA = "0x20ED4C4")]
	public List<SingerMiniMusicGamePhaseOneConfigData> GetAllConfigClone()
	{
		return null;
	}

	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x20ED6E4", Offset = "0x20ED6E4", VA = "0x20ED6E4", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x20ED808", Offset = "0x20ED808", VA = "0x20ED808", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
