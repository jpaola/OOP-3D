/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace HoloToolkit.Sharing {

public class XString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XString() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_XString(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public override string ToString() { 
    return GetString(); 
  }

  public override bool Equals(object obj)   
  {
    XString s = obj as XString; 
    if (ReferenceEquals(s, null)) {
      return false;
    }
    else {
      return IsEqual(s);
    }
  }

  public override int GetHashCode()
  {
    return GetString().GetHashCode(); 
  }

  public static bool operator ==(XString lhs, XString rhs)
  {
    if (ReferenceEquals(lhs, rhs)) {
      return true;
    }
    else if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null)) {
      return false;
    } else {
      return lhs.IsEqual(rhs);
    }
   }
  
  public static bool operator !=(XString lhs, XString rhs)
  {
    return !(lhs == rhs);
  }
  
  public static implicit operator XString(string s) {
    return new XString(s);
  } 

  public static implicit operator string(XString s)
  {
    return s.GetString();
  }

  public XString() : this(SharingClientPINVOKE.new_XString__SWIG_0(), true) {
  }

  public XString(string str) : this(SharingClientPINVOKE.new_XString__SWIG_1(str), true) {
    if (SharingClientPINVOKE.SWIGPendingException.Pending) throw SharingClientPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetLength() {
    uint ret = SharingClientPINVOKE.XString_GetLength(swigCPtr);
    return ret;
  }

  public bool IsEqual(XString otherStr) {
    bool ret = SharingClientPINVOKE.XString_IsEqual(swigCPtr, XString.getCPtr(otherStr));
    return ret;
  }

  public string GetString() {
    string ret = SharingClientPINVOKE.XString_GetString(swigCPtr);
    return ret;
  }

}

}
