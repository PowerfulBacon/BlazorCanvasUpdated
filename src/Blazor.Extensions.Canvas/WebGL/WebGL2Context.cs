using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Extensions.Canvas.WebGL
{
    /// <summary>
    /// Implement methods from https://developer.mozilla.org/en-US/docs/Web/API/WebGL2RenderingContext
    /// as needed or find a way to automate the addition of these methods.
    /// </summary>
    public partial class WebGLContext
    {

        #region CONSTANTS

        private const string COPY_BUFFER_SUB_DATA = "copyBufferSubData";

        private const string VERTEX_ATTRIB_DIVISOR = "vertexAttribDivisor";

        #endregion

        #region METHODS

        public async Task CopyBufferSubDataAsync(BufferType bufferType, int offset, int size) => await this.BatchCallAsync(COPY_BUFFER_SUB_DATA, isMethodCall: true, bufferType, offset, size);

        /// <summary>
        /// The WebGL2RenderingContext.vertexAttribDivisor() method of the WebGL 2 API modifies the rate at which generic vertex attributes
        /// advance when rendering multiple instances of primitives with gl.drawArraysInstanced() and gl.drawElementsInstanced(). 
        /// </summary>
        /// <param name="index">A GLuint specifying the index of the generic vertex attributes.</param>
        /// <param name="divisor">A GLuint specifying the number of instances that will pass between updates of the generic attribute. </param>
        /// <returns>None (undefined).</returns>
        public async Task VertexAttribDivisorAsync(int index, int divisor) => await this.BatchCallAsync(VERTEX_ATTRIB_DIVISOR, isMethodCall: true, index, divisor);

        #endregion

    }
}
