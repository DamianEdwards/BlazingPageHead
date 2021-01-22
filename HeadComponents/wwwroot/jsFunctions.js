// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function setDocumentTitle(title) {
    document.title = title;
}

export function processHeadContent(contentElement, suffix) {
    let newContent = contentElement.childNodes;
    newContent.forEach(n => {
        if (n.nodeType === 1) { // Element node
            n.setAttribute("data-phm", "true");
            if (n.nodeName === "TITLE") {
                setDocumentTitle(`${n.textContent}${suffix}`);
            } else {
                document.head.appendChild(n);
            }
        }
    });
}

export function resetHead() {
    let els = document.head.querySelectorAll("*[data-phm]");
    els.forEach(e => e.remove());
}
