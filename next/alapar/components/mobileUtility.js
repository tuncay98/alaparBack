import {
    isMobile
} from "react-device-detect";
import { useEffect, useRef } from 'react'
export function Device(props) {
    return <div>{props.children(isMobile)}</div>
}

export const MobileSelector = function MobileSelector(props) {

    const ref = useRef(0);

    return (<>
        <div className="ant-select w-full md:w-1/2 ant-select-single ant-select-show-arrow">
            <select ref={ref} state={props.state} className="ant-select-selector appearance-none" value={props.selected ?? ""} onChange={(e) => props.callback(e.target.value === ''? null: +e.target.value, {state: props.state})}>
                {props.children}
            </select>
            <span className="ant-select-arrow">
                <span role="img" aria-label="down" className="anticon anticon-down ant-select-suffix">
                    <svg viewBox="64 64 896 896" focusable="false" data-icon="down" width="1em" height="1em" fill="currentColor" aria-hidden="true"><path d="M884 256h-75c-5.1 0-9.9 2.5-12.9 6.6L512 654.2 227.9 262.6c-3-4.1-7.8-6.6-12.9-6.6h-75c-6.5 0-10.3 7.4-6.5 12.7l352.6 486.1c12.8 17.6 39 17.6 51.7 0l352.6-486.1c3.9-5.3.1-12.7-6.4-12.7z"></path></svg>
                </span>
            </span>
        </div>
    </>)
}


export const MobileNumberInput = function MobileNumberInput(props) {

    const ref = useRef(0)
    return <>
        <div className={'ant-input-number w-full'}>
            <input ref={ref} inputMode="numeric" type="number" onInput={(e)=>{e.target.value = e.target.value.replace(/^0+/, '');props.callback(e);}} onBlur={(e)=>{if(!e.target.value) return; if(+e.target.value<(+e.target.min ?? Number.MIN_VALUE)){ e.target.value=e.target.min; props.callback(e);} if(+e.target.value>(+e.target.max ?? Number.MAX_VALUE)){ e.target.value=e.target.max; props.callback(e);} }} name={props.name} className={props.className} min={props.min} max={props.max} step={props.step} placeholder={props.placeholder} />
        </div>
    </>

}