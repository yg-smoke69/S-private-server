using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000BF2")]
public class UIHudBlockEditMainController : UIPopupWindowController
{
	[Token(Token = "0x2000BF3")]
	private sealed class MKLNCELFIGE : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4006338")]
		[FieldOffset(Offset = "0x8")]
		internal UIPopupWindowController HIHMPBEPJBI;

		[Token(Token = "0x4006339")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudBlockEditMainController GADHAMJEKIM;

		[Token(Token = "0x400633A")]
		[FieldOffset(Offset = "0x10")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x400633B")]
		[FieldOffset(Offset = "0x14")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x400633C")]
		[FieldOffset(Offset = "0x18")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x17000776")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005A6B")]
			[Address(RVA = "0xF70B0C", Offset = "0xF70B0C", VA = "0xF70B0C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000777")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005A6C")]
			[Address(RVA = "0xF70B14", Offset = "0xF70B14", VA = "0xF70B14", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005A69")]
		[Address(RVA = "0xF706FC", Offset = "0xF706FC", VA = "0xF706FC")]
		public MKLNCELFIGE()
		{
		}

		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0xF70704", Offset = "0xF70704", VA = "0xF70704", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0xF70B1C", Offset = "0xF70B1C", VA = "0xF70B1C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0xF70B30", Offset = "0xF70B30", VA = "0xF70B30", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000BF4")]
	private sealed class CLPPKEINMCK
	{
		[Token(Token = "0x400633D")]
		[FieldOffset(Offset = "0x8")]
		internal EBlockCategory DFOBDABEAAB;

		[Token(Token = "0x400633E")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudBlockEditMainController GADHAMJEKIM;

		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0xF704E0", Offset = "0xF704E0", VA = "0xF704E0")]
		public CLPPKEINMCK()
		{
		}

		[Token(Token = "0x6005A70")]
		[Address(RVA = "0xF704E8", Offset = "0xF704E8", VA = "0xF704E8")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000BF5")]
	private sealed class NPPECLHODPJ
	{
		[Token(Token = "0x400633F")]
		[FieldOffset(Offset = "0x8")]
		internal GraphVarDefineData KGPLHDNCMIF;

		[Token(Token = "0x4006340")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudBlockEditMainController GADHAMJEKIM;

		[Token(Token = "0x6005A71")]
		[Address(RVA = "0xF70BB8", Offset = "0xF70BB8", VA = "0xF70BB8")]
		public NPPECLHODPJ()
		{
		}

		[Token(Token = "0x6005A72")]
		[Address(RVA = "0xF70BC0", Offset = "0xF70BC0", VA = "0xF70BC0")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000BF6")]
	private sealed class EJGLJAKEIAE
	{
		[Token(Token = "0x4006341")]
		[FieldOffset(Offset = "0x8")]
		internal GraphVarDefineData KGPLHDNCMIF;

		[Token(Token = "0x4006342")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudBlockEditMainController GADHAMJEKIM;

		[Token(Token = "0x6005A73")]
		[Address(RVA = "0xF705B4", Offset = "0xF705B4", VA = "0xF705B4")]
		public EJGLJAKEIAE()
		{
		}

		[Token(Token = "0x6005A74")]
		[Address(RVA = "0xF705BC", Offset = "0xF705BC", VA = "0xF705BC")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000BF7")]
	private sealed class FIKGCHILEKC
	{
		[Token(Token = "0x4006343")]
		[FieldOffset(Offset = "0x8")]
		internal GraphVarDefineData KGPLHDNCMIF;

		[Token(Token = "0x4006344")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudBlockEditMainController GADHAMJEKIM;

		[Token(Token = "0x6005A75")]
		[Address(RVA = "0xF705F0", Offset = "0xF705F0", VA = "0xF705F0")]
		public FIKGCHILEKC()
		{
		}

		[Token(Token = "0x6005A76")]
		[Address(RVA = "0xF705F8", Offset = "0xF705F8", VA = "0xF705F8")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000BF8")]
	private sealed class CMJCIAFBFIJ
	{
		[Token(Token = "0x4006345")]
		[FieldOffset(Offset = "0x8")]
		internal KeyValuePair<string, FuncDefineData> BEBAIIKFOII;

		[Token(Token = "0x4006346")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudBlockEditMainController GADHAMJEKIM;

		[Token(Token = "0x6005A77")]
		[Address(RVA = "0xF70520", Offset = "0xF70520", VA = "0xF70520")]
		public CMJCIAFBFIJ()
		{
		}

		[Token(Token = "0x6005A78")]
		[Address(RVA = "0xF70528", Offset = "0xF70528", VA = "0xF70528")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000BF9")]
	private sealed class MFPEJKGJENH
	{
		[Token(Token = "0x4006347")]
		[FieldOffset(Offset = "0x8")]
		internal KeyValuePair<string, FuncDefineData> BEBAIIKFOII;

		[Token(Token = "0x4006348")]
		[FieldOffset(Offset = "0x10")]
		internal UIHudBlockEditMainController GADHAMJEKIM;

		[Token(Token = "0x6005A79")]
		[Address(RVA = "0xF70668", Offset = "0xF70668", VA = "0xF70668")]
		public MFPEJKGJENH()
		{
		}

		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0xF70670", Offset = "0xF70670", VA = "0xF70670")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x2000BFA")]
	private sealed class GMJGMHNNDCP
	{
		[Token(Token = "0x4006349")]
		[FieldOffset(Offset = "0x8")]
		internal FuncDefineData KFEEFPLNDGG;

		[Token(Token = "0x400634A")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudBlockEditMainController GADHAMJEKIM;

		[Token(Token = "0x6005A7B")]
		[Address(RVA = "0xF7062C", Offset = "0xF7062C", VA = "0xF7062C")]
		public GMJGMHNNDCP()
		{
		}

		[Token(Token = "0x6005A7C")]
		[Address(RVA = "0xF70634", Offset = "0xF70634", VA = "0xF70634")]
		internal void CHOPCLCOBKC()
		{
		}
	}

	[Token(Token = "0x4006320")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<int, List<OEJEOMHHJAB>> IEHAHBBEHKD;

	[Token(Token = "0x4006321")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<int, List<OEJEOMHHJAB>> PFCGGHCLPEE;

	[Token(Token = "0x4006322")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, UIHudBlockTypeBtnItemController> NBKGDMMMNEI;

	[Token(Token = "0x4006323")]
	[FieldOffset(Offset = "0x54")]
	private readonly Dictionary<string, List<OEJEOMHHJAB>> PCMEMKMKOEF;

	[Token(Token = "0x4006324")]
	[FieldOffset(Offset = "0x58")]
	private readonly Dictionary<string, List<OEJEOMHHJAB>> AEBIGMJPGJP;

	[Token(Token = "0x4006325")]
	[FieldOffset(Offset = "0x5C")]
	private readonly Dictionary<string, OEJEOMHHJAB> KGGGELIPAPJ;

	[Token(Token = "0x4006326")]
	[FieldOffset(Offset = "0x60")]
	private readonly Dictionary<string, OEJEOMHHJAB> NGFKIOPGNGD;

	[Token(Token = "0x4006327")]
	[FieldOffset(Offset = "0x64")]
	private readonly Dictionary<string, OEJEOMHHJAB> DIIOEDOKFIA;

	[Token(Token = "0x4006328")]
	[FieldOffset(Offset = "0x68")]
	private UIHudBlockEditMainView NOJLDPLOCIH;

	[Token(Token = "0x4006329")]
	[FieldOffset(Offset = "0x6C")]
	private GraphData ANECPHJJNCO;

	[Token(Token = "0x400632A")]
	[FieldOffset(Offset = "0x70")]
	private EBlockCategory MIDEBLICMPK;

	[Token(Token = "0x400632B")]
	[FieldOffset(Offset = "0x74")]
	private OFBKCGAJOPK LBFJHAICCEL;

	[Token(Token = "0x400632C")]
	[FieldOffset(Offset = "0x78")]
	private BE_ProgrammingEnv OKCFHENDIJH;

	[Token(Token = "0x400632D")]
	[FieldOffset(Offset = "0x7C")]
	private BE_DragDropManager NAJPKFGMOKG;

	[Token(Token = "0x400632E")]
	[FieldOffset(Offset = "0x80")]
	private GraphData GJNDEMKCNAL;

	[Token(Token = "0x400632F")]
	[FieldOffset(Offset = "0x84")]
	private bool FMDOAJBCDNH;

	[Token(Token = "0x4006330")]
	[FieldOffset(Offset = "0x88")]
	private string NJILHDADLCB;

	[Token(Token = "0x4006331")]
	[FieldOffset(Offset = "0x8C")]
	private float JGHICCFLDMN;

	[Token(Token = "0x4006332")]
	[FieldOffset(Offset = "0x90")]
	private bool FIHBADLBKBB;

	[Token(Token = "0x4006333")]
	[FieldOffset(Offset = "0x91")]
	private bool OMDFIPBBIFO;

	[Token(Token = "0x4006334")]
	[FieldOffset(Offset = "0x94")]
	private ENPAKFNLPKA CLCEGCMEECD;

	[Token(Token = "0x4006335")]
	[FieldOffset(Offset = "0x98")]
	private HKNIDMNLHGJ EDCJONPGDIH;

	[Token(Token = "0x4006336")]
	[FieldOffset(Offset = "0x9C")]
	private HLHOAHFDDIK JCGGPEJMLCI;

	[Token(Token = "0x4006337")]
	[FieldOffset(Offset = "0xA0")]
	private GIAEFNOCFPD BLMHHEIIFCO;

	[Token(Token = "0x6005A3E")]
	[Address(RVA = "0x13A38D0", Offset = "0x13A38D0", VA = "0x13A38D0")]
	public UIHudBlockEditMainController()
	{
	}

	[Token(Token = "0x6005A3F")]
	[Address(RVA = "0x13A3A58", Offset = "0x13A3A58", VA = "0x13A3A58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6005A40")]
	[Address(RVA = "0x13A3AFC", Offset = "0x13A3AFC", VA = "0x13A3AFC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6005A41")]
	[Address(RVA = "0x13A6EE8", Offset = "0x13A6EE8", VA = "0x13A6EE8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6005A42")]
	[Address(RVA = "0x13A7074", Offset = "0x13A7074", VA = "0x13A7074")]
	private IEnumerator DMOGGBKFFIO()
	{
		return null;
	}

	[Token(Token = "0x6005A43")]
	[Address(RVA = "0x13A7140", Offset = "0x13A7140", VA = "0x13A7140")]
	private void DCHEOEINDGN()
	{
	}

	[Token(Token = "0x6005A44")]
	[Address(RVA = "0x13A72D0", Offset = "0x13A72D0", VA = "0x13A72D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6005A45")]
	[Address(RVA = "0x13A74D8", Offset = "0x13A74D8", VA = "0x13A74D8")]
	public void RecoverGraph(string AFPDJOLKBNO)
	{
	}

	[Token(Token = "0x6005A46")]
	[Address(RVA = "0x13A7A10", Offset = "0x13A7A10", VA = "0x13A7A10")]
	public void ResetEnvironment()
	{
	}

	[Token(Token = "0x6005A47")]
	[Address(RVA = "0x13A8844", Offset = "0x13A8844", VA = "0x13A8844")]
	private void KDCLJDACCIM()
	{
	}

	[Token(Token = "0x6005A48")]
	[Address(RVA = "0x13A8A80", Offset = "0x13A8A80", VA = "0x13A8A80")]
	private void FPJOMEPNCOC()
	{
	}

	[Token(Token = "0x6005A49")]
	[Address(RVA = "0x13A8E24", Offset = "0x13A8E24", VA = "0x13A8E24")]
	private void KDIGNBGDLPA()
	{
	}

	[Token(Token = "0x6005A4A")]
	[Address(RVA = "0x13AD808", Offset = "0x13AD808", VA = "0x13AD808")]
	private void KHKOJAGDJNK()
	{
	}

	[Token(Token = "0x6005A4B")]
	[Address(RVA = "0x13A4120", Offset = "0x13A4120", VA = "0x13A4120")]
	private void CHIEHOEFBNM()
	{
	}

	[Token(Token = "0x6005A4C")]
	[Address(RVA = "0x13A48CC", Offset = "0x13A48CC", VA = "0x13A48CC")]
	private void FJENMKBNDGI()
	{
	}

	[Token(Token = "0x6005A4D")]
	[Address(RVA = "0x13AD9FC", Offset = "0x13AD9FC", VA = "0x13AD9FC")]
	private void LHABOJJJPIN()
	{
	}

	[Token(Token = "0x6005A4E")]
	[Address(RVA = "0x13A56AC", Offset = "0x13A56AC", VA = "0x13A56AC")]
	private void ACFEPIIPBEK(EBlockCategory GCBKDIIGGCF, bool LGMFCELPLKE = false)
	{
	}

	[Token(Token = "0x6005A4F")]
	[Address(RVA = "0x13AE760", Offset = "0x13AE760", VA = "0x13AE760")]
	private void KNPOGBBIFMB()
	{
	}

	[Token(Token = "0x6005A50")]
	[Address(RVA = "0x13ADB7C", Offset = "0x13ADB7C", VA = "0x13ADB7C")]
	private void NHFKDFDKCGP(OFBKCGAJOPK GNJLBPLDLHG)
	{
	}

	[Token(Token = "0x6005A51")]
	[Address(RVA = "0x13AF150", Offset = "0x13AF150", VA = "0x13AF150")]
	private void OLAHEINPHIF()
	{
	}

	[Token(Token = "0x6005A52")]
	[Address(RVA = "0x13AF48C", Offset = "0x13AF48C", VA = "0x13AF48C")]
	private void MOHANCHBFNE()
	{
	}

	[Token(Token = "0x6005A53")]
	[Address(RVA = "0x13AF5A8", Offset = "0x13AF5A8", VA = "0x13AF5A8")]
	private int PCGDNGHAMEO(BlockData AAFBIANMEAL, BlockData KENDCFNPDCE)
	{
		return default(int);
	}

	[Token(Token = "0x6005A54")]
	[Address(RVA = "0x13AF87C", Offset = "0x13AF87C", VA = "0x13AF87C")]
	private void HOHNGBDODGE()
	{
	}

	[Token(Token = "0x6005A55")]
	[Address(RVA = "0x13AFA7C", Offset = "0x13AFA7C", VA = "0x13AFA7C")]
	private void MJJFPKGCNFM(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6005A56")]
	[Address(RVA = "0x13AFBD4", Offset = "0x13AFBD4", VA = "0x13AFBD4")]
	private void CCOCJDCOOON(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6005A57")]
	[Address(RVA = "0x13AFCC8", Offset = "0x13AFCC8", VA = "0x13AFCC8")]
	private void DEAOMHBGDGK(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6005A58")]
	[Address(RVA = "0x13A94F4", Offset = "0x13A94F4", VA = "0x13A94F4")]
	public void RefreshGraphVar()
	{
	}

	[Token(Token = "0x6005A59")]
	[Address(RVA = "0x13AFDD0", Offset = "0x13AFDD0", VA = "0x13AFDD0")]
	public void OnGraphVarDeleteBtnClick(GraphVarDefineData KGPLHDNCMIF)
	{
	}

	[Token(Token = "0x6005A5A")]
	[Address(RVA = "0x13B01BC", Offset = "0x13B01BC", VA = "0x13B01BC")]
	public void RemoveGraphVarCmd(GraphVarDefineData KGPLHDNCMIF)
	{
	}

	[Token(Token = "0x6005A5B")]
	[Address(RVA = "0x13B03E0", Offset = "0x13B03E0", VA = "0x13B03E0")]
	public void RemoveGraphVar(GraphVarDefineData KGPLHDNCMIF)
	{
	}

	[Token(Token = "0x6005A5C")]
	[Address(RVA = "0x13B0694", Offset = "0x13B0694", VA = "0x13B0694")]
	public void CreateLocalGraphVar(string HINJBPEDIAL, IOGCEGJJHLK PMGBACFJIHO)
	{
	}

	[Token(Token = "0x6005A5D")]
	[Address(RVA = "0x13B0A30", Offset = "0x13B0A30", VA = "0x13B0A30")]
	private bool PJONPAJOIAK(string HINJBPEDIAL, GraphData HGGHBIAIPOG)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A5E")]
	[Address(RVA = "0x13B0C98", Offset = "0x13B0C98", VA = "0x13B0C98")]
	private void CLOIOGMHABE(FuncDefineData KFEEFPLNDGG)
	{
	}

	[Token(Token = "0x6005A5F")]
	[Address(RVA = "0x13AB5F0", Offset = "0x13AB5F0", VA = "0x13AB5F0")]
	public void RefreshCustomFunc()
	{
	}

	[Token(Token = "0x6005A60")]
	[Address(RVA = "0x13B1454", Offset = "0x13B1454", VA = "0x13B1454")]
	private void MKPPPKGPBDD(FuncDefineData KFEEFPLNDGG)
	{
	}

	[Token(Token = "0x6005A61")]
	[Address(RVA = "0x13B1744", Offset = "0x13B1744", VA = "0x13B1744")]
	private void BILIIMCNKMI(FuncDefineData AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6005A62")]
	[Address(RVA = "0x13B1990", Offset = "0x13B1990", VA = "0x13B1990")]
	public void DeleteCustomFunc(FuncDefineData KFEEFPLNDGG)
	{
	}

	[Token(Token = "0x6005A63")]
	[Address(RVA = "0x13ACE58", Offset = "0x13ACE58", VA = "0x13ACE58")]
	private void HGLKGAIAPKL()
	{
	}

	[Token(Token = "0x6005A64")]
	[Address(RVA = "0x13B1BA0", Offset = "0x13B1BA0", VA = "0x13B1BA0")]
	private void DIBBLDBAKOK()
	{
	}

	[Token(Token = "0x6005A65")]
	[Address(RVA = "0x13B1BA8", Offset = "0x13B1BA8", VA = "0x13B1BA8")]
	private void JDKNDFGDJEG()
	{
	}

	[Token(Token = "0x6005A66")]
	[Address(RVA = "0x13B1BB0", Offset = "0x13B1BB0", VA = "0x13B1BB0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6005A67")]
	[Address(RVA = "0x13B1BB8", Offset = "0x13B1BB8", VA = "0x13B1BB8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6005A68")]
	[Address(RVA = "0x13B1BC0", Offset = "0x13B1BC0", VA = "0x13B1BC0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
