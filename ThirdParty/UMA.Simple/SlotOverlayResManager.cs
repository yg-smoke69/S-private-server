using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C7F")]
public class SlotOverlayResManager
{
	[Token(Token = "0x2003C80")]
	private sealed class _003CLoad_003Ec__AnonStorey0<T> where T : Object, INameProvider
	{
		[Token(Token = "0x4019B56")]
		[FieldOffset(Offset = "0x0")]
		internal Dictionary<int, int> map;

		[Token(Token = "0x4019B57")]
		[FieldOffset(Offset = "0x0")]
		internal SlotOverlayResManager _0024this;

		[Token(Token = "0x60182E3")]
		public _003CLoad_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60182E4")]
		internal void _003C_003Em__0(T li)
		{
		}
	}

	[Token(Token = "0x4019B47")]
	[FieldOffset(Offset = "0x0")]
	public static SlotOverlayResManager Instance;

	[Token(Token = "0x4019B48")]
	[FieldOffset(Offset = "0x8")]
	private bool _003CInited_003Ek__BackingField;

	[Token(Token = "0x4019B49")]
	private const int VAL_APK_HASH_FILE_NAME = 1073741824;

	[Token(Token = "0x4019B4A")]
	public const ushort INVALID_IDX = ushort.MaxValue;

	[Token(Token = "0x4019B4B")]
	private const int AB_SHIFT = 16;

	[Token(Token = "0x4019B4C")]
	private const int MAX_AB_COUNT = 16383;

	[Token(Token = "0x4019B4D")]
	private const int PATH_MASK = 65535;

	[Token(Token = "0x4019B4E")]
	[FieldOffset(Offset = "0xC")]
	private int m_AbsCount;

	[Token(Token = "0x4019B4F")]
	[FieldOffset(Offset = "0x10")]
	private List<string> m_Abs;

	[Token(Token = "0x4019B50")]
	[FieldOffset(Offset = "0x14")]
	private List<string> m_Pathes;

	[Token(Token = "0x4019B51")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, int> SlotMap;

	[Token(Token = "0x4019B52")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, int> OverlayMap;

	[Token(Token = "0x4019B53")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, ResourceID> m_AbToPlaceholderReses;

	[Token(Token = "0x4019B54")]
	[FieldOffset(Offset = "0x24")]
	private StringBuilder m_Sb;

	[Token(Token = "0x4019B55")]
	[FieldOffset(Offset = "0x28")]
	private string m_SbStr;

	[Token(Token = "0x170019A2")]
	public bool Inited
	{
		[Token(Token = "0x60182CD")]
		[Address(RVA = "0x2D68BB0", Offset = "0x2D68BB0", VA = "0x2D68BB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60182CE")]
		[Address(RVA = "0x2D68BB8", Offset = "0x2D68BB8", VA = "0x2D68BB8")]
		protected set
		{
		}
	}

	[Token(Token = "0x60182CC")]
	[Address(RVA = "0x2D68AD8", Offset = "0x2D68AD8", VA = "0x2D68AD8")]
	public SlotOverlayResManager()
	{
	}

	[Token(Token = "0x60182CF")]
	[Address(RVA = "0x2D68BC0", Offset = "0x2D68BC0", VA = "0x2D68BC0")]
	public static void InitInstanceInNeed()
	{
	}

	[Token(Token = "0x60182D0")]
	[Address(RVA = "0x2D68EA8", Offset = "0x2D68EA8", VA = "0x2D68EA8")]
	public void InitStringBuilderInNeed()
	{
	}

	[Token(Token = "0x60182D1")]
	[Address(RVA = "0x2D69FC0", Offset = "0x2D69FC0", VA = "0x2D69FC0")]
	public void Load(UMAAssetIndexer index)
	{
	}

	[Token(Token = "0x60182D2")]
	public Dictionary<int, int> Load<T>(UMAAssetIndexer index) where T : Object, INameProvider
	{
		return null;
	}

	[Token(Token = "0x60182D3")]
	[Address(RVA = "0x2D68FC0", Offset = "0x2D68FC0", VA = "0x2D68FC0")]
	public void Load(TextAsset asset, [Optional] Dictionary<string, int> hotAbs)
	{
	}

	[Token(Token = "0x60182D4")]
	[Address(RVA = "0x2D6A36C", Offset = "0x2D6A36C", VA = "0x2D6A36C")]
	private void Load(StringReader fs, Dictionary<string, int> hotAbs, Dictionary<string, string> abDeps)
	{
	}

	[Token(Token = "0x60182D5")]
	[Address(RVA = "0x2D6A614", Offset = "0x2D6A614", VA = "0x2D6A614")]
	private static List<string> LoadAbs(StringReader fs, Dictionary<string, string> abDeps)
	{
		return null;
	}

	[Token(Token = "0x60182D6")]
	[Address(RVA = "0x2D6ACF0", Offset = "0x2D6ACF0", VA = "0x2D6ACF0")]
	private static Dictionary<int, int> LoadSlotOverlays(StringReader fs, int count, List<string> abs, List<string> pathes, Dictionary<string, int> nonIndexedAbs, [Optional] Dictionary<string, int> hotAbs)
	{
		return null;
	}

	[Token(Token = "0x60182D7")]
	[Address(RVA = "0x2D6A5D0", Offset = "0x2D6A5D0", VA = "0x2D6A5D0")]
	private static bool ReadIntLine(StringReader r, out int val)
	{
		return default(bool);
	}

	[Token(Token = "0x60182D8")]
	[Address(RVA = "0x2D6A0D8", Offset = "0x2D6A0D8", VA = "0x2D6A0D8")]
	private void Load(BinaryReader bs, Dictionary<string, int> hotAbs, Dictionary<string, string> abDeps)
	{
	}

	[Token(Token = "0x60182D9")]
	[Address(RVA = "0x2D6B614", Offset = "0x2D6B614", VA = "0x2D6B614")]
	private static List<string> LoadAbs(BinaryReader bs, Dictionary<string, string> abDeps)
	{
		return null;
	}

	[Token(Token = "0x60182DA")]
	[Address(RVA = "0x2D6BB54", Offset = "0x2D6BB54", VA = "0x2D6BB54")]
	private static Dictionary<int, int> LoadSlotOverlays(BinaryReader bs, int count, List<string> abs, List<string> pathes, Dictionary<string, int> nonIndexedAbs, [Optional] Dictionary<string, int> hotAbs)
	{
		return null;
	}

	[Token(Token = "0x60182DB")]
	[Address(RVA = "0x2D6C268", Offset = "0x2D6C268", VA = "0x2D6C268")]
	public ResourceID GetAbResId(string ab)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60182DC")]
	public static bool GetSlotOrOverlay<T>(int hash, out string ab, out string path, bool assertNoReentry = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60182DD")]
	[Address(RVA = "0x2D5886C", Offset = "0x2D5886C", VA = "0x2D5886C")]
	public bool GetSlotOrOverlay(int hash, bool isSlot, out string ab, out string path, bool assertNoReentry = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60182DE")]
	[Address(RVA = "0x2D6C8B4", Offset = "0x2D6C8B4", VA = "0x2D6C8B4")]
	public bool GetSlot(int hash, out string ab, out string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60182DF")]
	[Address(RVA = "0x2D6C8EC", Offset = "0x2D6C8EC", VA = "0x2D6C8EC")]
	public bool GetOverlay(int hash, out string ab, out string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60182E0")]
	[Address(RVA = "0x2D6C924", Offset = "0x2D6C924", VA = "0x2D6C924")]
	public bool GetSlotOrOverlayAb(int hash, bool isSlot, out string ab)
	{
		return default(bool);
	}

	[Token(Token = "0x60182E1")]
	[Address(RVA = "0x2D6C39C", Offset = "0x2D6C39C", VA = "0x2D6C39C")]
	private bool GetSlotOrOverlay(Dictionary<int, int> dic, int hash, out string ab, out string path, bool getPath = true, bool assertNoReentry = false, bool skipError = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60182E2")]
	[Address(RVA = "0x2D6C96C", Offset = "0x2D6C96C", VA = "0x2D6C96C")]
	private string GetPathFromHash(int hash, bool useSharedStr = false)
	{
		return null;
	}
}
