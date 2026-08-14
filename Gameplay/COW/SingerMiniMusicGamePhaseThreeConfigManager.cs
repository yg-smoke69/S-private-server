using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200022F")]
public class SingerMiniMusicGamePhaseThreeConfigManager : SingletonModule<SingerMiniMusicGamePhaseThreeConfigManager>
{
	[Token(Token = "0x2000230")]
	private sealed class _003CGetConfigCloneByGameID_003Ec__AnonStorey0
	{
		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0x8")]
		internal int gameID;

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x20EE644", Offset = "0x20EE644", VA = "0x20EE644")]
		public _003CGetConfigCloneByGameID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x20EE64C", Offset = "0x20EE64C", VA = "0x20EE64C")]
		internal bool _003C_003Em__0(SingerMiniMusicGamePhaseThreeConfigData data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000D6B")]
	[FieldOffset(Offset = "0xC")]
	private List<SingerMiniMusicGamePhaseThreeConfigData> dataList;

	[Token(Token = "0x1700016A")]
	public List<SingerMiniMusicGamePhaseThreeConfigData> DataList
	{
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x20EDDA0", Offset = "0x20EDDA0", VA = "0x20EDDA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x20EDCDC", Offset = "0x20EDCDC", VA = "0x20EDCDC")]
	public SingerMiniMusicGamePhaseThreeConfigManager()
	{
	}

	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x20EDDF8", Offset = "0x20EDDF8", VA = "0x20EDDF8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6000B20")]
	[Address(RVA = "0x20EDF1C", Offset = "0x20EDF1C", VA = "0x20EDF1C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6000B21")]
	[Address(RVA = "0x20EDFD8", Offset = "0x20EDFD8", VA = "0x20EDFD8")]
	public List<SingerMiniMusicGamePhaseThreeConfigData> GetAllConfigClone()
	{
		return null;
	}

	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x20EE1E4", Offset = "0x20EE1E4", VA = "0x20EE1E4")]
	public List<SingerMiniMusicGamePhaseThreeConfigData> GetConfigCloneByGameID(int gameID)
	{
		return null;
	}
}
