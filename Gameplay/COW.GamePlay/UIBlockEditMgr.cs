using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.Gameplay.UGC.BlockEdit;
using ECAPackage;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000BD3")]
public class UIBlockEditMgr : MonoBehaviour
{
	[Token(Token = "0x2000BD4")]
	private sealed class OOJDDDMBGJB
	{
		[Token(Token = "0x40062C0")]
		[FieldOffset(Offset = "0x8")]
		internal ValueData LLEPHDNFGGP;

		[Token(Token = "0x60059C7")]
		[Address(RVA = "0x139B3E0", Offset = "0x139B3E0", VA = "0x139B3E0")]
		public OOJDDDMBGJB()
		{
		}

		[Token(Token = "0x60059C8")]
		[Address(RVA = "0x139BB7C", Offset = "0x139BB7C", VA = "0x139BB7C")]
		internal bool CHOPCLCOBKC(UGCHudPrefabIndexInfo HGMBMICDALC)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000BD5")]
	private sealed class DBBLDNOGMPN
	{
		[Token(Token = "0x40062C1")]
		[FieldOffset(Offset = "0x8")]
		internal string FFDHFKIMFDG;

		[Token(Token = "0x60059C9")]
		[Address(RVA = "0x139B3E8", Offset = "0x139B3E8", VA = "0x139B3E8")]
		public DBBLDNOGMPN()
		{
		}

		[Token(Token = "0x60059CA")]
		[Address(RVA = "0x139B98C", Offset = "0x139B98C", VA = "0x139B98C")]
		internal bool CHOPCLCOBKC(string HGMBMICDALC)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000BD6")]
	private sealed class LFJGLLDFHKD
	{
		[Token(Token = "0x40062C2")]
		[FieldOffset(Offset = "0x8")]
		internal string PCHOMNAAOEA;

		[Token(Token = "0x40062C3")]
		[FieldOffset(Offset = "0xC")]
		internal int DDAHKHLLNAE;

		[Token(Token = "0x60059CB")]
		[Address(RVA = "0x139B3F0", Offset = "0x139B3F0", VA = "0x139B3F0")]
		public LFJGLLDFHKD()
		{
		}

		[Token(Token = "0x60059CC")]
		[Address(RVA = "0x139BA94", Offset = "0x139BA94", VA = "0x139BA94")]
		internal bool CHOPCLCOBKC(ECAVarTypeDefine HGMBMICDALC)
		{
			return default(bool);
		}

		[Token(Token = "0x60059CD")]
		[Address(RVA = "0x139BB44", Offset = "0x139BB44", VA = "0x139BB44")]
		internal bool HJGBDJENEAM(BEEnumData HGMBMICDALC)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000BD7")]
	private sealed class FBGACFPENID
	{
		[Token(Token = "0x40062C4")]
		[FieldOffset(Offset = "0x8")]
		internal int IGPIBKONBNO;

		[Token(Token = "0x40062C5")]
		[FieldOffset(Offset = "0xC")]
		internal int DDAHKHLLNAE;

		[Token(Token = "0x60059CE")]
		[Address(RVA = "0x139B3F8", Offset = "0x139B3F8", VA = "0x139B3F8")]
		public FBGACFPENID()
		{
		}

		[Token(Token = "0x60059CF")]
		[Address(RVA = "0x139BA1C", Offset = "0x139BA1C", VA = "0x139BA1C")]
		internal bool CHOPCLCOBKC(UGCHudPrefabIndexInfo HGMBMICDALC)
		{
			return default(bool);
		}

		[Token(Token = "0x60059D0")]
		[Address(RVA = "0x139BA5C", Offset = "0x139BA5C", VA = "0x139BA5C")]
		internal bool HJGBDJENEAM(BEEnumData HGMBMICDALC)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000BD8")]
	private sealed class AKBALPOMFJP
	{
		[Token(Token = "0x40062C6")]
		[FieldOffset(Offset = "0x8")]
		internal string NNNJLKCJMIO;

		[Token(Token = "0x60059D1")]
		[Address(RVA = "0x139B688", Offset = "0x139B688", VA = "0x139B688")]
		public AKBALPOMFJP()
		{
		}

		[Token(Token = "0x60059D2")]
		[Address(RVA = "0x139B76C", Offset = "0x139B76C", VA = "0x139B76C")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x40062BB")]
	[FieldOffset(Offset = "0x0")]
	private static UIBlockEditMgr _003CBEGMFLJLODE_003Ek__BackingField;

	[Token(Token = "0x40062BC")]
	[FieldOffset(Offset = "0x4")]
	public static Color VariableColor;

	[Token(Token = "0x40062BD")]
	[FieldOffset(Offset = "0x14")]
	public static Color NotAvailableColor;

	[Token(Token = "0x40062BE")]
	[FieldOffset(Offset = "0xC")]
	private readonly Dictionary<int, FCDHDMMKGBH> OKBHGAJLJAP;

	[Token(Token = "0x40062BF")]
	[FieldOffset(Offset = "0x24")]
	private static Dictionary<string, int> FJMFALFHIOJ;

	[Token(Token = "0x1700076B")]
	public static UIBlockEditMgr NAHILPCMBNM
	{
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0x138E3A4", Offset = "0x138E3A4", VA = "0x138E3A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x138E430", Offset = "0x138E430", VA = "0x138E430")]
		private set
		{
		}
	}

	[Token(Token = "0x60059B2")]
	[Address(RVA = "0x138DCF8", Offset = "0x138DCF8", VA = "0x138DCF8")]
	public UIBlockEditMgr()
	{
	}

	[Token(Token = "0x60059B5")]
	[Address(RVA = "0x138E4C0", Offset = "0x138E4C0", VA = "0x138E4C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60059B6")]
	[Address(RVA = "0x138E600", Offset = "0x138E600", VA = "0x138E600")]
	public Color GetBlockTypeColor(EBlockCategory EGDEOBOEAGA)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x60059B7")]
	[Address(RVA = "0x138E878", Offset = "0x138E878", VA = "0x138E878")]
	public string GetBlockTypeName(EBlockCategory EGDEOBOEAGA)
	{
		return null;
	}

	[Token(Token = "0x60059B8")]
	[Address(RVA = "0x138EA74", Offset = "0x138EA74", VA = "0x138EA74")]
	public string GetBlockIconName(EBlockCategory EGDEOBOEAGA)
	{
		return null;
	}

	[Token(Token = "0x60059B9")]
	[Address(RVA = "0x138EBBC", Offset = "0x138EBBC", VA = "0x138EBBC")]
	public GameObject BuildGraphBlock(BlockData HLJNGDMOCNA, bool MFOHKCKDPKF = false)
	{
		return null;
	}

	[Token(Token = "0x60059BA")]
	[Address(RVA = "0x1390768", Offset = "0x1390768", VA = "0x1390768")]
	public GameObject BuildEventBlock(BlockData HLJNGDMOCNA, bool MFOHKCKDPKF = false)
	{
		return null;
	}

	[Token(Token = "0x60059BB")]
	[Address(RVA = "0x1393DC4", Offset = "0x1393DC4", VA = "0x1393DC4")]
	public GameObject BuildFuncDefinerBlock(BlockData HLJNGDMOCNA)
	{
		return null;
	}

	[Token(Token = "0x60059BC")]
	[Address(RVA = "0x138EFF0", Offset = "0x138EFF0", VA = "0x138EFF0")]
	public GameObject BuildActionBlock(BlockData HLJNGDMOCNA, bool MFOHKCKDPKF = false)
	{
		return null;
	}

	[Token(Token = "0x60059BD")]
	[Address(RVA = "0x13916F0", Offset = "0x13916F0", VA = "0x13916F0")]
	public GameObject BuildDataBlock(BlockData HLJNGDMOCNA, bool MFOHKCKDPKF = false)
	{
		return null;
	}

	[Token(Token = "0x60059BE")]
	[Address(RVA = "0x139AAE8", Offset = "0x139AAE8", VA = "0x139AAE8")]
	public void BuildDataFuncCallerBlock(BlockData HLJNGDMOCNA, FuncDefineData CAEAIAFECOL, BE_DataBlock OOFJJGBMNKC)
	{
	}

	[Token(Token = "0x60059BF")]
	[Address(RVA = "0x139A130", Offset = "0x139A130", VA = "0x139A130")]
	public void BuildActionFuncCallerBlock(BlockData HLJNGDMOCNA, FuncDefineData MEDELINCDHF, BE_Block OOFJJGBMNKC)
	{
	}

	[Token(Token = "0x60059C0")]
	[Address(RVA = "0x1395214", Offset = "0x1395214", VA = "0x1395214")]
	public GameObject GetResObj(ResourceID KMIPBIGPDPI, [Optional] Transform PHLFBBIAEFE)
	{
		return null;
	}

	[Token(Token = "0x60059C1")]
	[Address(RVA = "0x1395520", Offset = "0x1395520", VA = "0x1395520")]
	public List<IPIKJNGGEOB> BuildField(BlockFieldDefine CIOJMHNCIAP, BlockData HLJNGDMOCNA, Transform DLJGNPBCGAA)
	{
		return null;
	}

	[Token(Token = "0x60059C2")]
	[Address(RVA = "0x13953A0", Offset = "0x13953A0", VA = "0x13953A0")]
	public GameObject BuildBodyBlock(int LEPGEAPLMEO, int CGCBNFNAJCJ, bool POLBKHKCGOO, bool ICPEDKHOMLH, Transform PHLFBBIAEFE, bool AAGAFCJBNIE)
	{
		return null;
	}

	[Token(Token = "0x60059C3")]
	[Address(RVA = "0x1398E28", Offset = "0x1398E28", VA = "0x1398E28")]
	public void SetEntityPropertyPairData(BE_BlockSectionHeader_DropdownList ECCEOLGAIOM, BE_BlockSectionHeader_DropdownList PLHKCOKOIIJ, string CJMGDKMJNKO)
	{
	}

	[Token(Token = "0x60059C4")]
	[Address(RVA = "0x139B400", Offset = "0x139B400", VA = "0x139B400")]
	public void ShowErrPop(string GOFEKMEBGDA, float LEBOAIEJCPJ = 2f)
	{
	}

	[Token(Token = "0x60059C5")]
	[Address(RVA = "0x1398A00", Offset = "0x1398A00", VA = "0x1398A00")]
	private void OLICDFBBHDK(string NNNJLKCJMIO, Transform DLJGNPBCGAA)
	{
	}
}
