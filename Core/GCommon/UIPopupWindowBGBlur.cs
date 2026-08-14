using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace GCommon;

[Token(Token = "0x2004160")]
public class UIPopupWindowBGBlur : MonoBehaviour
{
	[Token(Token = "0x2004161")]
	private sealed class _003CGetSomeTimeForGlassBlur_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401B6ED")]
		[FieldOffset(Offset = "0x8")]
		internal GameObject obj;

		[Token(Token = "0x401B6EE")]
		[FieldOffset(Offset = "0xC")]
		internal UIPopupWindowController _003Cctrl_003E__1;

		[Token(Token = "0x401B6EF")]
		[FieldOffset(Offset = "0x10")]
		internal int _003Ci_003E__2;

		[Token(Token = "0x401B6F0")]
		[FieldOffset(Offset = "0x14")]
		internal UIPopupWindowBGBlur _0024this;

		[Token(Token = "0x401B6F1")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x401B6F2")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x401B6F3")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x17001D73")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601AB7B")]
			[Address(RVA = "0x2BB9348", Offset = "0x2BB9348", VA = "0x2BB9348", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001D74")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601AB7C")]
			[Address(RVA = "0x2BB9350", Offset = "0x2BB9350", VA = "0x2BB9350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601AB79")]
		[Address(RVA = "0x2BB8E28", Offset = "0x2BB8E28", VA = "0x2BB8E28")]
		public _003CGetSomeTimeForGlassBlur_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601AB7A")]
		[Address(RVA = "0x2BB8E30", Offset = "0x2BB8E30", VA = "0x2BB8E30", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601AB7D")]
		[Address(RVA = "0x2BB9358", Offset = "0x2BB9358", VA = "0x2BB9358", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601AB7E")]
		[Address(RVA = "0x2BB936C", Offset = "0x2BB936C", VA = "0x2BB936C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2004162")]
	private sealed class _003CGetSomeTimeForGlassBlurList_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401B6F4")]
		[FieldOffset(Offset = "0x8")]
		internal List<GameObject> objs;

		[Token(Token = "0x401B6F5")]
		[FieldOffset(Offset = "0xC")]
		internal List<GameObject>.Enumerator _0024locvar0;

		[Token(Token = "0x401B6F6")]
		[FieldOffset(Offset = "0x1C")]
		internal GameObject _003Cobj_003E__1;

		[Token(Token = "0x401B6F7")]
		[FieldOffset(Offset = "0x20")]
		internal List<GameObject>.Enumerator _0024locvar1;

		[Token(Token = "0x401B6F8")]
		[FieldOffset(Offset = "0x30")]
		internal UIPopupWindowBGBlur _0024this;

		[Token(Token = "0x401B6F9")]
		[FieldOffset(Offset = "0x34")]
		internal object _0024current;

		[Token(Token = "0x401B6FA")]
		[FieldOffset(Offset = "0x38")]
		internal bool _0024disposing;

		[Token(Token = "0x401B6FB")]
		[FieldOffset(Offset = "0x3C")]
		internal int _0024PC;

		[Token(Token = "0x17001D75")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601AB81")]
			[Address(RVA = "0x2BB9A8C", Offset = "0x2BB9A8C", VA = "0x2BB9A8C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001D76")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601AB82")]
			[Address(RVA = "0x2BB9A94", Offset = "0x2BB9A94", VA = "0x2BB9A94", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601AB7F")]
		[Address(RVA = "0x2BB93F4", Offset = "0x2BB93F4", VA = "0x2BB93F4")]
		public _003CGetSomeTimeForGlassBlurList_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x601AB80")]
		[Address(RVA = "0x2BB93FC", Offset = "0x2BB93FC", VA = "0x2BB93FC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601AB83")]
		[Address(RVA = "0x2BB9A9C", Offset = "0x2BB9A9C", VA = "0x2BB9A9C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601AB84")]
		[Address(RVA = "0x2BB9B1C", Offset = "0x2BB9B1C", VA = "0x2BB9B1C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401B6E6")]
	[FieldOffset(Offset = "0xC")]
	private Shader m_Shader;

	[Token(Token = "0x401B6E7")]
	[FieldOffset(Offset = "0x10")]
	private Material m_Material;

	[Token(Token = "0x401B6E8")]
	[FieldOffset(Offset = "0x14")]
	private Camera m_Camera;

	[Token(Token = "0x401B6E9")]
	[FieldOffset(Offset = "0x18")]
	private CommandBuffer m_CommandBuffer;

	[Token(Token = "0x401B6EA")]
	[FieldOffset(Offset = "0x1C")]
	private RenderTexture m_blurTexture;

	[Token(Token = "0x401B6EB")]
	[FieldOffset(Offset = "0x20")]
	private bool m_NeedExec;

	[Token(Token = "0x401B6EC")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<GameObject, Vector3> m_lastPosDic;

	[Token(Token = "0x17001D72")]
	public bool Initialized
	{
		[Token(Token = "0x601AB71")]
		[Address(RVA = "0x2CABC84", Offset = "0x2CABC84", VA = "0x2CABC84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601AB6C")]
	[Address(RVA = "0x2CABB24", Offset = "0x2CABB24", VA = "0x2CABB24")]
	public UIPopupWindowBGBlur()
	{
	}

	[Token(Token = "0x601AB6D")]
	[Address(RVA = "0x2CABBB0", Offset = "0x2CABBB0", VA = "0x2CABBB0")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x601AB6E")]
	[Address(RVA = "0x2CABC94", Offset = "0x2CABC94", VA = "0x2CABC94")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601AB6F")]
	[Address(RVA = "0x2CABC98", Offset = "0x2CABC98", VA = "0x2CABC98")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x601AB70")]
	[Address(RVA = "0x2CAC678", Offset = "0x2CAC678", VA = "0x2CAC678")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x601AB72")]
	[Address(RVA = "0x2CABCB4", Offset = "0x2CABCB4", VA = "0x2CABCB4")]
	private void Initialize()
	{
	}

	[Token(Token = "0x601AB73")]
	[Address(RVA = "0x2CAC67C", Offset = "0x2CAC67C", VA = "0x2CAC67C")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x601AB74")]
	[Address(RVA = "0x2C9AE5C", Offset = "0x2C9AE5C", VA = "0x2C9AE5C")]
	public void ExecCommandBuffer(GameObject root)
	{
	}

	[Token(Token = "0x601AB75")]
	[Address(RVA = "0x2C9B030", Offset = "0x2C9B030", VA = "0x2C9B030")]
	public void ExecCommandBuffer(List<GameObject> roots)
	{
	}

	[Token(Token = "0x601AB76")]
	[Address(RVA = "0x2C9B1DC", Offset = "0x2C9B1DC", VA = "0x2C9B1DC")]
	public void ExecCommandBufferNoRoot()
	{
	}

	[Token(Token = "0x601AB77")]
	[Address(RVA = "0x2CAC720", Offset = "0x2CAC720", VA = "0x2CAC720")]
	private IEnumerator GetSomeTimeForGlassBlur(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x601AB78")]
	[Address(RVA = "0x2CAC7C0", Offset = "0x2CAC7C0", VA = "0x2CAC7C0")]
	private IEnumerator GetSomeTimeForGlassBlurList(List<GameObject> objs)
	{
		return null;
	}
}
