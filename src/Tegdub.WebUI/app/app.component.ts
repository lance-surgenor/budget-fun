import { Component } from '@angular/core';
import { OnInit } from '@angular/core';

@Component ({
    selector: 'tegdub',

    template: `
    <h1>{{title}}
    <h2>Testing</h2>
    `,

    styles: [`
    `]
})

export class AppComponent implements OnInit {
    title = 'Tegdub';

    ngOnInit(): void {
        
    }
}